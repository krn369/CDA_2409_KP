document.addEventListener('DOMContentLoaded', function() {
    // Mobile Navigation Toggle
    const mobileNavToggle = document.querySelector('.mobile-nav-toggle');
    const mainNav = document.querySelector('.main-nav ul');
    
    mobileNavToggle.addEventListener('click', function() {
        const visibility = mainNav.getAttribute('data-visible');
        
        if (visibility === "false") {
            mainNav.setAttribute('data-visible', "true");
            mobileNavToggle.setAttribute('aria-expanded', "true");
            mobileNavToggle.innerHTML = '<i class="fas fa-times"></i>';
            document.body.style.overflow = 'hidden';
        } else {
            mainNav.setAttribute('data-visible', "false");
            mobileNavToggle.setAttribute('aria-expanded', "false");
            mobileNavToggle.innerHTML = '<i class="fas fa-bars"></i>';
            document.body.style.overflow = '';
        }
    });

    // Close mobile menu when clicking a link
    document.querySelectorAll('.main-nav a').forEach(link => {
        link.addEventListener('click', function() {
            if (mainNav.getAttribute('data-visible') === "true") {
                mainNav.setAttribute('data-visible', "false");
                mobileNavToggle.setAttribute('aria-expanded', "false");
                mobileNavToggle.innerHTML = '<i class="fas fa-bars"></i>';
                document.body.style.overflow = '';
            }
        });
    });

    // Smooth Scrolling for Anchor Links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function(e) {
            e.preventDefault();
            
            const targetId = this.getAttribute('href');
            if (targetId === '#') return;
            
            const targetElement = document.querySelector(targetId);
            if (targetElement) {
                window.scrollTo({
                    top: targetElement.offsetTop - 100,
                    behavior: 'smooth'
                });
            }
        });
    });

    // Newsletter Form Submission
    const newsletterForm = document.querySelector('.newsletter-form');
    if (newsletterForm) {
        newsletterForm.addEventListener('submit', function(e) {
            e.preventDefault();
            
            const emailInput = this.querySelector('input[type="email"]');
            const email = emailInput.value.trim();
            
            if (validateEmail(email)) {
                showNewsletterSuccess();
                emailInput.value = '';
                
                // In a real implementation, you would send this to your server
                // Example: sendNewsletterSignup(email);
            } else {
                showNewsletterError();
            }
        });
    }

    // Trend Cards - Add click functionality
    document.querySelectorAll('.trend-item, .gallery-item').forEach(item => {
        item.addEventListener('click', function() {
            // This could open a modal or navigate to a detail page
            const title = this.querySelector('h3')?.textContent;
            console.log(`Opening details for: ${title}`);
            
            // Example: window.location.href = `/trends/${slugify(title)}`;
        });
    });

    // Featured Articles - Read More buttons
    document.querySelectorAll('.read-more').forEach(button => {
        button.addEventListener('click', function(e) {
            e.preventDefault();
            const articleTitle = this.closest('.featured-card').querySelector('h3').textContent;
            console.log(`Reading more about: ${articleTitle}`);
            
            // Example: window.location.href = `/articles/${slugify(articleTitle)}`;
        });
    });

    // Scroll Reveal Animation
    if (typeof ScrollReveal !== 'undefined') {
        const scrollReveal = ScrollReveal({
            origin: 'bottom',
            distance: '60px',
            duration: 1000,
            delay: 200,
            reset: true
        });

        scrollReveal.reveal('.featured-card, .trend-item, .gallery-item, .about-content', {
            interval: 200
        });
    }

    // Back to Top Button
    const backToTopButton = document.createElement('button');
    backToTopButton.className = 'back-to-top';
    backToTopButton.setAttribute('aria-label', 'Back to top');
    backToTopButton.innerHTML = '<i class="fas fa-arrow-up"></i>';
    document.body.appendChild(backToTopButton);
    
    window.addEventListener('scroll', function() {
        if (window.pageYOffset > 300) {
            backToTopButton.classList.add('show');
        } else {
            backToTopButton.classList.remove('show');
        }
    });
    
    backToTopButton.addEventListener('click', function() {
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });

    // Image Lazy Loading
    const lazyLoadImages = () => {
        const lazyImages = [].slice.call(document.querySelectorAll('img.lazy'));
        
        if ('IntersectionObserver' in window) {
            let lazyImageObserver = new IntersectionObserver(function(entries, observer) {
                entries.forEach(function(entry) {
                    if (entry.isIntersecting) {
                        let lazyImage = entry.target;
                        lazyImage.src = lazyImage.dataset.src;
                        lazyImage.classList.remove('lazy');
                        lazyImageObserver.unobserve(lazyImage);
                    }
                });
            });
            
            lazyImages.forEach(function(lazyImage) {
                lazyImageObserver.observe(lazyImage);
            });
        } else {
            // Fallback for browsers without IntersectionObserver
            lazyImages.forEach(function(lazyImage) {
                lazyImage.src = lazyImage.dataset.src;
                lazyImage.classList.remove('lazy');
            });
        }
    };
    
    // Initialize lazy loading
    lazyLoadImages();

    // Helper Functions
    function validateEmail(email) {
        const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return re.test(email);
    }

    function showNewsletterSuccess() {
        const existingAlert = document.querySelector('.newsletter-alert');
        if (existingAlert) existingAlert.remove();
        
        const alert = document.createElement('div');
        alert.className = 'newsletter-alert success';
        alert.textContent = 'Thank you for subscribing! Look for our next newsletter soon.';
        newsletterForm.parentNode.insertBefore(alert, newsletterForm.nextSibling);
        
        setTimeout(() => {
            alert.style.opacity = '0';
            setTimeout(() => alert.remove(), 500);
        }, 5000);
    }

    function showNewsletterError() {
        const existingAlert = document.querySelector('.newsletter-alert');
        if (existingAlert) existingAlert.remove();
        
        const alert = document.createElement('div');
        alert.className = 'newsletter-alert error';
        alert.textContent = 'Please enter a valid email address.';
        newsletterForm.parentNode.insertBefore(alert, newsletterForm.nextSibling);
        
        setTimeout(() => {
            alert.style.opacity = '0';
            setTimeout(() => alert.remove(), 500);
        }, 5000);
    }

    function slugify(text) {
        return text.toString().toLowerCase()
            .replace(/\s+/g, '-')           // Replace spaces with -
            .replace(/[^\w\-]+/g, '')       // Remove all non-word chars
            .replace(/\-\-+/g, '-')         // Replace multiple - with single -
            .replace(/^-+/, '')             // Trim - from start of text
            .replace(/-+$/, '');            // Trim - from end of text
    }

    // Send newsletter signup to server (example implementation)
    function sendNewsletterSignup(email) {
        // In a real implementation, you would use fetch() to send to your backend
        console.log(`Submitting email: ${email}`);
        // Example:
        // fetch('/api/newsletter', {
        //     method: 'POST',
        //     headers: {
        //         'Content-Type': 'application/json',
        //     },
        //     body: JSON.stringify({ email: email }),
        // })
        // .then(response => response.json())
        // .then(data => console.log('Success:', data))
        // .catch(error => console.error('Error:', error));
    }

    // Initialize animations on page load
    function initAnimations() {
        const elements = document.querySelectorAll('.animate-on-load');
        elements.forEach((el, index) => {
            el.style.animation = `fadeInUp 1s ease ${index * 0.1}s both`;
        });
    }
    
    initAnimations();
});

// Debounce function for scroll/resize events
function debounce(func, wait = 20, immediate = true) {
    let timeout;
    return function() {
        const context = this, args = arguments;
        const later = function() {
            timeout = null;
            if (!immediate) func.apply(context, args);
        };
        const callNow = immediate && !timeout;
        clearTimeout(timeout);
        timeout = setTimeout(later, wait);
        if (callNow) func.apply(context, args);
    };
}

// Throttle function for scroll/resize events
function throttle(func, limit = 100) {
    let lastFunc;
    let lastRan;
    return function() {
        const context = this;
        const args = arguments;
        if (!lastRan) {
            func.apply(context, args);
            lastRan = Date.now();
        } else {
            clearTimeout(lastFunc);
            lastFunc = setTimeout(function() {
                if ((Date.now() - lastRan) >= limit) {
                    func.apply(context, args);
                    lastRan = Date.now();
                }
            }, limit - (Date.now() - lastRan));
        }
    };
}

// Check if element is in viewport
function isInViewport(element) {
    const rect = element.getBoundingClientRect();
    return (
        rect.top >= 0 &&
        rect.left >= 0 &&
        rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
        rect.right <= (window.innerWidth || document.documentElement.clientWidth)
    );
}

// Add event listener for scroll with debounce
window.addEventListener('scroll', debounce(function() {
    // This could be used to trigger animations or other effects
    // when elements come into view during scrolling
    const animatedElements = document.querySelectorAll('.animate-on-scroll');
    animatedElements.forEach(el => {
        if (isInViewport(el)) {
            el.classList.add('animated');
        }
    });
}));