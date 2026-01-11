document.addEventListener("DOMContentLoaded", function () {
  const plans = [
    { type: "Health", base: 3000 },
    { type: "Life", base: 5000 },
    { type: "Vehicle", base: 2000 }
  ];

  const planCards = document.getElementById("planCards");
  const policy = document.getElementById("policy");
  const filterPolicy = document.getElementById("filterPolicy");
  const coverage = document.getElementById("coverage");
  const coverageValue = document.getElementById("coverageValue");
  const premium = document.getElementById("premium");

  const nameInput = document.getElementById("name");
  const ageInput = document.getElementById("age");
  const emailInput = document.getElementById("email");

  const enquiryForm = document.getElementById("enquiryForm");
  const customerTable = document.getElementById("customerTable");
  const searchInput = document.getElementById("searchInput");

  const customerCount = document.getElementById("customerCount");
  const policyCount = document.getElementById("policyCount");
  const totalPremium = document.getElementById("totalPremium");

  let customers = [];

  plans.forEach(p => {
    planCards.innerHTML += `
      <div class="bg-white p-6 rounded-xl shadow hover:shadow-xl transition">
        <h3 class="font-semibold text-lg">${p.type} Insurance</h3>
        <p class="text-slate-600">Base Premium ₹${p.base}</p>
        <a href="#enquiry"
           class="inline-block mt-3 bg-blue-600 text-white px-4 py-2 rounded"
           onclick="document.getElementById('policy').value='${p.type}'">
          Enroll
        </a>
      </div>`;
    policy.innerHTML += `<option value="${p.type}">${p.type}</option>`;
    filterPolicy.innerHTML += `<option value="${p.type}">${p.type}</option>`;
  });

  function calculatePremium(age, policyType, coverage) {
    let base = 0;
    if (policyType === "Health") base = 3000;
    if (policyType === "Life") base = 5000;
    if (policyType === "Vehicle") base = 2000;
    let result = base;
    if (age > 45) result += result * 0.2;
    result += Math.floor((coverage - 100000) / 100000) * 500;
    return Math.round(result);
  }

  function updatePremium() {
    if (!ageInput.value || !policy.value) {
      premium.value = "";
      return;
    }
    premium.value = calculatePremium(
      Number(ageInput.value),
      policy.value,
      Number(coverage.value)
    );
  }

  ageInput.addEventListener("input", updatePremium);
  policy.addEventListener("change", updatePremium);

  coverage.addEventListener("input", function () {
    coverageValue.textContent = coverage.value;
    updatePremium();
  });

  enquiryForm.addEventListener("submit", function (e) {
    e.preventDefault();

    const errors = enquiryForm.querySelectorAll("p");
    errors.forEach(e => e.textContent = "");

    let valid = true;

    if (!nameInput.value.trim()) {
      errors[0].textContent = "Name required";
      valid = false;
    }
    if (!ageInput.value || ageInput.value < 18) {
      errors[1].textContent = "Age must be 18 or above";
      valid = false;
    }
    if (!emailInput.value.trim()) {
      errors[2].textContent = "Email required";
      valid = false;
    }
    if (!policy.value) {
      errors[3].textContent = "Select policy type";
      valid = false;
    }

    if (!valid) return;

    customers.push({
      id: customers.length + 1,
      name: nameInput.value.trim(),
      age: Number(ageInput.value),
      policyType: policy.value,
      coverage: Number(coverage.value),
      premium: Number(premium.value)
    });

    renderTable();
    updateDashboard();

    enquiryForm.reset();
    coverage.value = 100000;
    coverageValue.textContent = 100000;
    premium.value = "";
  });

  function renderTable(list = customers) {
    customerTable.innerHTML = list.map(c => `
      <tr>
        <td class="p-3">${c.name}</td>
        <td class="p-3">${c.age}</td>
        <td class="p-3">${c.policyType}</td>
        <td class="p-3">₹${c.coverage}</td>
        <td class="p-3">₹${c.premium}</td>
      </tr>
    `).join("");
  }

  function updateDashboard() {
    customerCount.textContent = customers.length;
    policyCount.textContent = customers.length;
    totalPremium.textContent =
      customers.reduce((sum, c) => sum + c.premium, 0);
  }

  function applyFilters() {
    const term = searchInput.value.toLowerCase();
    const type = filterPolicy.value;

    const filtered = customers
      .filter(c => c.name.toLowerCase().includes(term))
      .filter(c => !type || c.policyType === type);

    renderTable(filtered);
  }

  searchInput.addEventListener("input", applyFilters);
  filterPolicy.addEventListener("change", applyFilters);

});
const menuBtn = document.getElementById("menuBtn");
const menu = document.getElementById("menu");

menuBtn.addEventListener("click", function () {
  menu.classList.toggle("hidden");
});
