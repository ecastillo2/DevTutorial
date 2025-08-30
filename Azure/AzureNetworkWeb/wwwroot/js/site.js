// Azure Network Architecture - Interactive Features

document.addEventListener('DOMContentLoaded', function() {
    // Add interactive hover effects to SVG elements
    const svgElements = document.querySelectorAll('svg rect, svg circle');
    
    svgElements.forEach(element => {
        element.addEventListener('mouseenter', function() {
            this.style.filter = 'brightness(1.1)';
            this.style.cursor = 'pointer';
        });
        
        element.addEventListener('mouseleave', function() {
            this.style.filter = 'brightness(1)';
        });
    });
    
    // Add tooltips to network components
    const networkComponents = document.querySelectorAll('[data-toggle="tooltip"]');
    networkComponents.forEach(component => {
        // Initialize tooltips if Bootstrap is available
        if (typeof bootstrap !== 'undefined') {
            new bootstrap.Tooltip(component);
        }
    });
    
    // Smooth scrolling for anchor links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
            }
        });
    });
});

// Function to highlight network paths on hover
function highlightPath(pathId) {
    const path = document.getElementById(pathId);
    if (path) {
        path.style.strokeWidth = '6';
        path.style.filter = 'drop-shadow(0 0 10px rgba(59, 130, 246, 0.5))';
    }
}

function unhighlightPath(pathId) {
    const path = document.getElementById(pathId);
    if (path) {
        path.style.strokeWidth = '';
        path.style.filter = '';
    }
}