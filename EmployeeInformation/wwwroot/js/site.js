// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function AgeCalculation() { 
    debugger;
var dobstring = document.getElementById('DOB').value;
var dob = new Date(dobstring);
var month_diff = Date.now() - dob.getTime();
var age_dt = new Date(month_diff);
var year = age_dt.getUTCFullYear();
var age = Math.abs(year - 1970);
    document.getElementById('Age').value = age;
}

