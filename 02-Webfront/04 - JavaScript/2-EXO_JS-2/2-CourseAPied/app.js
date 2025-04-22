// Create a new Vue instance
new Vue({
    el: '#app',  // Attach Vue to the <div id="app">

    // Reactive data
    data() {
        return {
            participants: [],         // All participants data
            selectedCountries: [],    // Currently selected countries (checkboxes)
            availableCountries: [],   // All unique countries from data
            isLoading: true,          // Loading indicator
            error: null               // Error message
        };
    },

    // Code that runs when the component is created
    created() {
        this.fetchRaceData();  // Load data at the beginning
    },

    // Computed properties that update automatically when data changes
    computed: {
        // Return the first participant (who has the shortest time)
        winner() {
            return this.participants[0] || {};
        },

        // Filter participants by selected countries
        filteredParticipants() {
            if (this.selectedCountries.length === 0) {
                return this.participants; // If no filter is selected, show all
            }
            return this.participants.filter(p =>
                this.selectedCountries.includes(p.pays)
            );
        },

        // Calculate the average time of filtered participants
        averageTime() {
            if (this.filteredParticipants.length === 0) return '0min00s';

            const totalSeconds = this.filteredParticipants.reduce(
                (sum, p) => sum + p.temps, 0
            );
            const avgSeconds = Math.round(totalSeconds / this.filteredParticipants.length);
            return this.formatTime(avgSeconds);
        }
    },

    // Methods used by the component
    methods: {
        // Load JSON data from file
        async fetchRaceData() {
            try {
                const response = await fetch('resultat10000metres.json');

                // If something goes wrong
                if (!response.ok) throw new Error('Failed to load data');

                const data = await response.json();

                // Sort participants by time (ascending)
                this.participants = data.sort((a, b) => a.temps - b.temps);

                // Get unique list of countries
                this.availableCountries = [...new Set(data.map(p => p.pays))];

                // Select all countries by default
                this.selectedCountries = [...this.availableCountries];

            } catch (err) {
                this.error = err.message;
                console.error('Error:', err);
            } finally {
                this.isLoading = false;
            }
        },

        // Convert seconds into "XXminYYs" format
        formatTime(seconds) {
            const mins = Math.floor(seconds / 60);
            const secs = seconds % 60;
            return `${mins}min${secs.toString().padStart(2, '0')}s`;
        },

        // Calculate difference between a participant's time and winner's time
        formatTimeDifference(seconds) {
            if (!this.winner || !this.winner.temps) return '+0s';
            const difference = seconds - this.winner.temps;
            return difference > 0 ? `+${difference}s` : '+0s';
        },

        // Split full name and return last name (second word)
        getLastName(fullName) {
            return fullName.split(' ')[1] || '';
        },

        // Split full name and return first name (first word)
        getFirstName(fullName) {
            return fullName.split(' ')[0] || '';
        }
    }
});
