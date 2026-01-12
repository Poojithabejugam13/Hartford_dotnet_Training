const element1 = document.getElementById("element1");
const element2 = document.getElementById("element2");
const element3 = document.getElementById("element3");
const element4 = document.getElementById("element4");
const elmnt = document.getElementById("elmnt");
const paySection = document.querySelector(".paymentSection");
const payBtn = document.getElementById("payBtn");

paySection.addEventListener("click", () => {
  element1.textContent = "Parent div activated first due to event bubbling";
});

payBtn.addEventListener("click", () => {
  element2.textContent = "Child Button clicked";
});

const policyContainer = document.querySelector(".policyContainer");
const policyBtn = document.querySelector(".policyDetails");

policyContainer.addEventListener("click", () => {
  element3.textContent = "Parent container activated first due to event capturing";
}, true);

policyBtn.addEventListener("click", () => {
  element4.textContent = "Child policy details clicked";
}, true);

const deleteContainer = document.querySelector(".deletePolicyDetails");
const deleteBtn = document.querySelector(".delpolicyDetails");

deleteContainer.addEventListener("click", () => {
  elmnt.textContent = "Parent container activated";
});

deleteBtn.addEventListener("click", (e) => {
  e.stopPropagation();
  elmnt.textContent = "only Child executed due to stopPropagation";
});

const claimRow = document.getElementById("claimRow");
const approveBtn = document.getElementById("approveBtn");
const output = document.getElementById("showclaimdetails");

claimRow.addEventListener("click", () => {
  console.log("Capturing: Claim Row validated");
  output.innerHTML += "<p>Capturing: Claim Row validated</p>";
}, true);

claimRow.addEventListener("click", () => {
  console.log("Bubbling: Opening Claim Details");
  output.innerHTML += "<p>Opening Claim Details</p>";
});

approveBtn.addEventListener("click", (e) => {
  e.stopPropagation();
  output.innerHTML += "<p>Claim Approved</p>";
});
// approveBtn.addEventListener("click", (e) => {
//   output.innerHTML += "<p>Claim Approved</p>";
// });
//With stopPropagation only Capturing and Target executes
//Without stopPropagation all Capturing ,target and bubblin executes
