document.addEventListener('DOMContentLoaded', () => {
    const apiKey = 'RhEpGjjxXIgbBJK1OqavYjI0eH8stPCZ9Ad3I4LT';
    const apiUrl = 'https://data.cityofnewyork.us/resource/kpav-sd4t.json';

    function fetchDataAndDisplay() {
        // Fetch data from the API
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {

                // Calculate career level counts
                const careerLevelCounts = calculateCategoryCounts(data, 'career_level');

                // Update career level table
                updateTable('careerLevelTable', careerLevelCounts);

                // Create a bar chart for career levels
                createChart('careerLevelChart', careerLevelCounts);
            })
            .catch(error => {
                console.error('Error fetching and displaying data:', error);
            });
    }

    function calculateCategoryCounts(data, categoryField) {
        const categoryCounts = {};

        data.forEach(item => {
            const category = item[categoryField];
            if (category) {
                categoryCounts[category] = (categoryCounts[category] || 0) + 1;
            }
        });

        return categoryCounts;
    }

    function updateTable(tableId, categoryCounts) {
        const table = document.getElementById(tableId);
        const tbody = table.querySelector('tbody');

        // Clear the existing table rows
        tbody.innerHTML = '';

        // Iterate over category counts and create table rows
        for (const category in categoryCounts) {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${category}</td>
                <td>${categoryCounts[category]}</td>
            `;
            tbody.appendChild(row);
        }
    }

    function createChart(chartId, categoryCounts) {
        // Use Chart.js to create a bar chart with category data
        const chartCanvas = document.getElementById(chartId);

        const categories = Object.keys(categoryCounts);
        const counts = Object.values(categoryCounts);

        const chart = new Chart(chartCanvas, {
            type: 'bar',
            data: {
                labels: categories,
                datasets: [{
                    label: 'Number of Jobs',
                    data: counts,
                    backgroundColor: 'rgba(75, 192, 192, 0.2)',
                    borderColor: 'rgba(75, 192, 192, 1)',
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    }

    // Initial fetch and display on page load
    fetchDataAndDisplay();
});
