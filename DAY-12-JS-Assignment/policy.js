async function getPolicyDetails() {
  try {
    const response = await fetch(
      "https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata"
    );
    const data = await response.json();
    console.log("Policy Details:", data);
    const container = document.getElementById("policies");
    container.innerHTML = data
      .map(item => `
        <div>
          <h3>Name:${item.name}</h3>
          <p>Type: ${item.type}</p>
          <p>Premium: ₹${item.premium}</p>
          <p>Duration: ${item.duration} year(s)</p>
          
        </div>
      `)
      .join("");
    const healthPolicies = data.filter(p => p.type === "Health");
    const lifePolicies = data.filter(p => p.type === "Life");
    const vehiclePolicies = data.filter(p => p.type === "Vehicle");
    getPolicyById(data,8);
    calculateTotalPremium(data);
    displayPolicies(healthPolicies, "health");
    displayPolicies(lifePolicies, "life");
    displayPolicies(vehiclePolicies, "vehicle");
    let pid=document.getElementById("pid");
    total_premium(data,pid);
    let disount=premium_discount(data);
    document.getElementById("d").innerHTML=disount.map(p => `${p.name} : ₹${p.premium}`)
  } catch (error) {
    console.error("Error fetching policy details:", error);
  }
}
getPolicyDetails();  
function displayPolicies(policies, id) {
  const container = document.getElementById(id);

  container.innerHTML = policies
    .map(item => `
      <div>
        <h3>Name:${item.name}</h3>
        <p>Type: ${item.type}</p>
        <p>Premium: ₹${item.premium}</p>
        <p>Duration: ${item.duration} year(s)</p>
      </div>
    `)
    .join("");
}
function total_premium(p,id){
    id.innerHTML+=` : ₹${p.reduce((a,l)=> a + l.premium, 0)}`;
}
function premium_discount(data){
    return data.map(i=>{
        if(i.premium>10000){
            return {...i,premium:0.9*i.premium}
        }
        else{
            return i
        }
    })}
function approvePolicy(policyName, callback) {
    setTimeout(() => {
    callback(`Policy, "${policyName}" Approved`);
  }, 2000);
}
approvePolicy("Health Plus", function (message) {
  document.getElementById("approvalStatus").textContent = message;
});
function approvePolicyPromise(policyName) {
  return new Promise((resolve, reject) => {
    document.getElementById("approvalStat").textContent =
      `Approving policy "${policyName}"...`;
    setTimeout(() => {
      const approved = true;
      if (approved) {
        resolve(`Policy "${policyName}" Approved`);
      } else {
        reject(`Policy "${policyName}" Approval Failed`);
      }
    }, 2000);
  });
}
approvePolicyPromise("HealthPlus");

function getPolicyById(policies, id) {
  try {
    const policy=policies.find(p => p.id === id);
    if (!policy) {
      throw new Error("Invalid Policy ID");
    }
    return policy;
  } catch (error) {
    console.error(error.message);
  }
}
function calculateTotalPremium(policies) {
  try {
    if (typeof policies.premium!=="number") {
      throw new Error("Invalid premium data");
    }
      console.log("premium handled")
  } catch (error) {
    console.error(error.message)
  }
}
