// C# Microservices Architecture - Site JavaScript

document.addEventListener('DOMContentLoaded', function() {
    // Initialize tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Add copy functionality to all code blocks
    initializeCodeCopyButtons();
    
    // Initialize Prism for syntax highlighting
    if (typeof Prism !== 'undefined') {
        Prism.highlightAll();
    }
    
    // Add interactive behavior to diagrams
    initializeDiagramInteractivity();
    
    // Initialize smooth scrolling
    initializeSmoothScrolling();
});

// Add copy buttons to code blocks
function initializeCodeCopyButtons() {
    const codeBlocks = document.querySelectorAll('pre code');
    
    codeBlocks.forEach((block) => {
        const pre = block.parentElement;
        
        // Skip if button already exists
        if (pre.querySelector('.copy-button')) return;
        
        const wrapper = document.createElement('div');
        wrapper.className = 'code-block-wrapper position-relative';
        
        const button = document.createElement('button');
        button.className = 'copy-button';
        button.innerHTML = '<i class="fas fa-copy"></i> Copy';
        button.title = 'Copy to clipboard';
        
        button.addEventListener('click', async () => {
            const text = block.textContent;
            try {
                await navigator.clipboard.writeText(text);
                button.innerHTML = '<i class="fas fa-check"></i> Copied!';
                button.classList.add('copied');
                
                setTimeout(() => {
                    button.innerHTML = '<i class="fas fa-copy"></i> Copy';
                    button.classList.remove('copied');
                }, 2000);
            } catch (err) {
                console.error('Failed to copy:', err);
                button.innerHTML = '<i class="fas fa-times"></i> Failed';
                setTimeout(() => {
                    button.innerHTML = '<i class="fas fa-copy"></i> Copy';
                }, 2000);
            }
        });
        
        pre.style.position = 'relative';
        pre.appendChild(button);
    });
}

// Initialize diagram interactivity
function initializeDiagramInteractivity() {
    // Service component hover effects
    const serviceComponents = document.querySelectorAll('.service-card, .azure-card, .pattern-card');
    
    serviceComponents.forEach(component => {
        component.addEventListener('mouseenter', function() {
            this.style.transform = 'translateY(-5px)';
        });
        
        component.addEventListener('mouseleave', function() {
            this.style.transform = 'translateY(0)';
        });
    });
    
    // SVG diagram interactions
    const svgComponents = document.querySelectorAll('svg .component');
    
    svgComponents.forEach(component => {
        component.addEventListener('click', function() {
            const text = this.querySelector('text');
            if (text) {
                const componentName = text.textContent.trim();
                console.log('Clicked component:', componentName);
            }
        });
    });
}

// Initialize smooth scrolling
function initializeSmoothScrolling() {
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            const href = this.getAttribute('href');
            if (href === '#') return;
            
            e.preventDefault();
            const target = document.querySelector(href);
            if (target) {
                const offset = 80; // Account for fixed navbar
                const targetPosition = target.offsetTop - offset;
                
                window.scrollTo({
                    top: targetPosition,
                    behavior: 'smooth'
                });
            }
        });
    });
}
