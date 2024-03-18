window.addEventListener('DOMContentLoaded',(event) => {
    getVisitCount();
})
const functionApiUrl = 'https://getresumecounter2410.azurewebsites.net/api/GetResumeCounter?code=glTp8FbgShTHGVI7_d9ue18rPHm-zsR30-M9k_w8GDFaAzFuXnGNPg=='
const localfunctionApi = 'https://localhost:7071/api/GetResumeCounter';

const getVisitCount = () => {
    let count = 30;
    fetch(functionApiUrl).then(response => {
        return response.json()
    }).then(response => {
        console.log("Website called function API.");
        count = response.count;
        document.getElementById("counter").innerText = count;
    }).catch(function(error){
        console.log(error);
    });
    return count;
}