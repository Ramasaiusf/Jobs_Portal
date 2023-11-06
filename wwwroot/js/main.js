document.addEventListener('DOMContentLoaded', () => {
    const apiKey = 'RhEpGjjxXIgbBJK1OqavYjI0eH8stPCZ9Ad3I4LT';
    const apiUrl = 'https://data.cityofnewyork.us/resource/kpav-sd4t.json';

    const jobPostingsTable = document.getElementById('jobPostingsTable');
    const tableBody = jobPostingsTable.querySelector('tbody');

    const recordsPerPage = 20;
    let currentPage = 1;

    function fetchJobPostings(page) {
        const offset = (page - 1) * recordsPerPage;
        const urlWithParams = `${apiUrl}?$offset=${offset}&$limit=${recordsPerPage}`;

        fetch(urlWithParams)
            .then(response => response.json())
            .then(data => {
                // Clear the existing table rows
                tableBody.innerHTML = '';

                data.forEach(job => {
                    const row = document.createElement('tr');
                    row.innerHTML = `
                    <td>${job.job_id}</td>
<td>${job.agency}</td>
<td>${job.career_level}</td>
<td>${job.work_location}</td>
<td>${job.division_work_unit}</td>
<td>${job.posting_date}</td>
<td>${job.posting_updated}</td>
<td>${job.salary_range_from} - ${job.salary_range_to}</td>
                `;
                    tableBody.appendChild(row);
                });
            })
            .catch(error => {
                console.error('Error fetching data:', error);
            });
    }

    // Initial fetch on page load
    fetchJobPostings(currentPage);

    // Pagination controls
    function updatePagination() {
        // Implement previous and next buttons, update currentPage accordingly
    }

    // Example: Previous button
    window.onload = function () {
        const previousButton = document.getElementById('previousButton');
        previousButton.addEventListener('click', () => {
            if (currentPage > 1) {
                currentPage--;
                fetchJobPostings(currentPage);
                updatePagination();
            }
        });
    }
   

    // Example: Next button
    window.onload = function () {
        const nextButton = document.getElementById('nextButton');
        nextButton.addEventListener('click', () => {
            currentPage++;
            fetchJobPostings(currentPage);
            updatePagination();
        });
    }


    // Initial pagination setup
    updatePagination();
});
