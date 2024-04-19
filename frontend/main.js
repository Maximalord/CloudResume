window.addEventListener('DOMContentLoaded', (event) => {
    getVisitCount();
});

const functionApiUrl = '';

const getVisitCount = () => {
    fetch(functionApiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(response => {
            console.log("Website called function API.");
            const count = response.count;
            document.getElementById("counter").innerText = count;
        })
        .catch(error => {
            console.error('Error fetching data:', error);
        });
};



