const myApp = {
    data() {
        return{
            nbClics: 0
        }
    },

    methods : {
        incrementer() {
            this.nbClics++;
        }, 
        
    }
}

Vue.createApp(myApp).mount('#app');
