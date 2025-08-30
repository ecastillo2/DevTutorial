// SQL Interview Web Application JavaScript

document.addEventListener('DOMContentLoaded', function() {
    // Initialize tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Copy to clipboard functionality
    addCopyButtons();

    // SVG diagram interactivity
    initializeDiagramInteractivity();

    // Query execution animation
    initializeQueryAnimation();

    // Smooth scrolling for anchor links
    initializeSmoothScrolling();
});

// Add copy buttons to code blocks
function addCopyButtons() {
    const codeBlocks = document.querySelectorAll('pre code');
    
    codeBlocks.forEach((block) => {
        const pre = block.parentElement;
        const wrapper = document.createElement('div');
        wrapper.className = 'position-relative';
        
        const button = document.createElement('button');
        button.className = 'btn btn-sm btn-outline-secondary position-absolute top-0 end-0 m-2';
        button.innerHTML = '<i class="fas fa-copy"></i>';
        button.title = 'Copy to clipboard';
        
        button.addEventListener('click', async () => {
            const text = block.textContent;
            try {
                await navigator.clipboard.writeText(text);
                button.innerHTML = '<i class="fas fa-check"></i>';
                button.classList.remove('btn-outline-secondary');
                button.classList.add('btn-success');
                
                setTimeout(() => {
                    button.innerHTML = '<i class="fas fa-copy"></i>';
                    button.classList.remove('btn-success');
                    button.classList.add('btn-outline-secondary');
                }, 2000);
            } catch (err) {
                console.error('Failed to copy:', err);
                button.innerHTML = '<i class="fas fa-times"></i>';
                button.classList.add('btn-danger');
            }
        });
        
        pre.parentNode.insertBefore(wrapper, pre);
        wrapper.appendChild(pre);
        wrapper.appendChild(button);
    });
}

// Initialize SVG diagram interactivity
function initializeDiagramInteractivity() {
    const svgElements = document.querySelectorAll('.er-diagram svg');
    
    svgElements.forEach(svg => {
        // Add hover effects to tables
        const tables = svg.querySelectorAll('[id$="-table"]');
        
        tables.forEach(table => {
            table.style.cursor = 'pointer';
            
            table.addEventListener('mouseenter', function() {
                this.style.opacity = '0.8';
                highlightRelatedTables(this.id);
            });
            
            table.addEventListener('mouseleave', function() {
                this.style.opacity = '1';
                resetHighlights();
            });
            
            table.addEventListener('click', function() {
                showTableDetails(this.id);
            });
        });
    });
}

// Highlight related tables when hovering
function highlightRelatedTables(tableId) {
    const svg = document.querySelector('.er-diagram svg');
    const relationships = svg.querySelector('#relationships');
    
    if (tableId === 'employee-table') {
        const employment = svg.querySelector('#employment-table');
        if (employment) employment.style.opacity = '0.6';
    } else if (tableId === 'company-table') {
        const employment = svg.querySelector('#employment-table');
        if (employment) employment.style.opacity = '0.6';
    } else if (tableId === 'employment-table') {
        const employee = svg.querySelector('#employee-table');
        const company = svg.querySelector('#company-table');
        if (employee) employee.style.opacity = '0.6';
        if (company) company.style.opacity = '0.6';
    }
}

// Reset highlight effects
function resetHighlights() {
    const svg = document.querySelector('.er-diagram svg');
    const tables = svg.querySelectorAll('[id$="-table"]');
    tables.forEach(table => {
        table.style.opacity = '1';
    });
}

// Show table details in a modal
function showTableDetails(tableId) {
    const tableName = tableId.replace('-table', '').charAt(0).toUpperCase() + 
                     tableId.replace('-table', '').slice(1);
    
    const modalContent = getTableDetailsContent(tableName);
    
    // Create and show modal dynamically
    const modalHtml = `
        <div class="modal fade" id="tableDetailsModal" tabindex="-1">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">${tableName} Table Details</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
                    </div>
                    <div class="modal-body">
                        ${modalContent}
                    </div>
                </div>
            </div>
        </div>
    `;
    
    // Remove existing modal if any
    const existingModal = document.getElementById('tableDetailsModal');
    if (existingModal) {
        existingModal.remove();
    }
    
    document.body.insertAdjacentHTML('beforeend', modalHtml);
    const modal = new bootstrap.Modal(document.getElementById('tableDetailsModal'));
    modal.show();
}

// Get detailed content for each table
function getTableDetailsContent(tableName) {
    const details = {
        'Employee': `
            <h6>Purpose</h6>
            <p>Stores basic information about employees including their personal details and address information.</p>
            <h6>Key Columns</h6>
            <ul>
                <li><strong>employee_id</strong>: Unique identifier for each employee</li>
                <li><strong>first_name, last_name</strong>: Employee's name</li>
                <li><strong>street_address, city, state, zip_code</strong>: Complete address information</li>
                <li><strong>department_id</strong>: Links to department (if departments table exists)</li>
            </ul>
            <h6>Relationships</h6>
            <p>One employee can have multiple employment records (job history)</p>
        `,
        'Employment': `
            <h6>Purpose</h6>
            <p>Junction table that tracks the employment history of employees at different companies.</p>
            <h6>Key Columns</h6>
            <ul>
                <li><strong>employment_id</strong>: Unique identifier for each employment record</li>
                <li><strong>employee_id</strong>: Links to Employee table</li>
                <li><strong>company_id</strong>: Links to Company table</li>
                <li><strong>salary</strong>: Current or historical salary</li>
                <li><strong>is_active</strong>: Indicates if this is current employment</li>
            </ul>
            <h6>Business Rules</h6>
            <p>An employee can work for multiple companies over time, and a company can have multiple employees.</p>
        `,
        'Company': `
            <h6>Purpose</h6>
            <p>Stores information about companies that employ or have employed workers.</p>
            <h6>Key Columns</h6>
            <ul>
                <li><strong>company_id</strong>: Unique identifier for each company</li>
                <li><strong>company_name</strong>: Official name of the company</li>
                <li><strong>industry</strong>: Business sector</li>
                <li><strong>headquarters_city</strong>: Location of main office</li>
            </ul>
            <h6>Data Integrity</h6>
            <p>Company names should be unique to prevent duplicate entries.</p>
        `
    };
    
    return details[tableName] || '<p>No additional details available.</p>';
}

// Initialize query execution animation
function initializeQueryAnimation() {
    const executeBtn = document.querySelector('a[href*="ExecuteQuery"]');
    if (executeBtn) {
        executeBtn.addEventListener('click', function(e) {
            e.preventDefault();
            
            // Add loading animation
            const originalContent = this.innerHTML;
            this.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Executing...';
            this.classList.add('disabled');
            
            // Simulate execution and redirect
            setTimeout(() => {
                window.location.href = this.href;
            }, 1000);
        });
    }
}

// Smooth scrolling for anchor links
function initializeSmoothScrolling() {
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
}

// Interactive query builder (for future enhancement)
function initializeQueryBuilder() {
    const queryBuilder = document.getElementById('queryBuilder');
    if (!queryBuilder) return;
    
    // This would be expanded to create an interactive query building interface
    // where users can drag and drop tables, select columns, and build WHERE clauses
}

// Performance metrics visualization
function showPerformanceMetrics(executionTime, rowsReturned) {
    const metricsHtml = `
        <div class="alert alert-info mt-3">
            <h6><i class="fas fa-chart-line me-2"></i>Query Performance</h6>
            <div class="row">
                <div class="col-md-6">
                    <small>Execution Time: <strong>${executionTime}ms</strong></small>
                </div>
                <div class="col-md-6">
                    <small>Rows Returned: <strong>${rowsReturned}</strong></small>
                </div>
            </div>
        </div>
    `;
    
    const container = document.querySelector('.query-results');
    if (container) {
        container.insertAdjacentHTML('afterend', metricsHtml);
    }
}

// Export functionality for query results
function exportQueryResults(format) {
    const table = document.querySelector('.query-results table');
    if (!table) return;
    
    if (format === 'csv') {
        exportToCSV(table);
    } else if (format === 'json') {
        exportToJSON(table);
    }
}

// Export table to CSV
function exportToCSV(table) {
    const rows = table.querySelectorAll('tr');
    let csv = [];
    
    rows.forEach(row => {
        const cols = row.querySelectorAll('td, th');
        const rowData = Array.from(cols).map(col => col.textContent.trim());
        csv.push(rowData.join(','));
    });
    
    downloadFile('query_results.csv', csv.join('\n'), 'text/csv');
}

// Export table to JSON
function exportToJSON(table) {
    const headers = Array.from(table.querySelectorAll('th')).map(th => th.textContent.trim());
    const rows = table.querySelectorAll('tbody tr');
    const data = [];
    
    rows.forEach(row => {
        const cols = row.querySelectorAll('td');
        const rowData = {};
        cols.forEach((col, index) => {
            rowData[headers[index]] = col.textContent.trim();
        });
        data.push(rowData);
    });
    
    downloadFile('query_results.json', JSON.stringify(data, null, 2), 'application/json');
}

// Download file utility
function downloadFile(filename, content, contentType) {
    const blob = new Blob([content], { type: contentType });
    const url = window.URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = filename;
    document.body.appendChild(a);
    a.click();
    window.URL.revokeObjectURL(url);
    document.body.removeChild(a);
}