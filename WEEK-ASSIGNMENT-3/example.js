let allusers=[]
const getUsers = async () => {
  const loader = document.getElementById("loader");
  loader.style.display = "block";
  const stored = loadFromStorage();
  if (stored) {
    allusers = stored;
    display(allusers);
    loader.style.display = "none";
    return;
  }
  try {
    const response = await fetch("https://69663546f6de16bde44c915b.mockapi.io/api/policy/bankusers");
    if (!response.ok) {           
      throw new Error("Failed to fetch data");
    }
      const data=await response.json()
      allusers = data.map(user => ({
          ...user,
          balance: Math.floor(Math.random() * (50000 - 10000 + 1)) + 10000,
          transactions: []
        }));
        saveToStorage();
        display(allusers);
  }
  catch (error) {
    alert("Something went wrong. Please try again.");
    console.error("Error fetching users:", error);
  }
  finally {
    loader.style.display = "none";  
  }
};
//task-1
function display(users){
    const container = document.getElementById("bank_users");
    container.innerHTML = ""; 
    users.map((user)=>{
        let div=document.createElement("div")
        div.style="border:1px black;box-shadow:1px 1px 18px grey;border-radius:10px;padding:10px;margin:10px;width:287px;"
        div.innerHTML=`<h4 style="font-weight:bold; font-size:21px; text-align:center;">${user.name}</h4>
        <p style="text-align:center;"><b>AccountNumber:</b>${user.accountNo}</p>
        <p style="text-align:center;"><b>Email:</b>${user.email}</p>
        <p style="text-align:center;"><b>City:</b>${user.address.city}</p>
        <p style="text-align:center;"><b>Balance:</b>${user.balance}</p>
        <div style="display:flex;justify-content:space-around;">
        <button id="dep-${user.accountNo}" style="background-color:blue;border:1px solid blue; cursor:pointer;padding:4px;">Deposit</button>
        <button id="with-${user.accountNo}" style="background-color:green;border:1px solid green; cursor:pointer;padding:4px;">Withdraw</button>
        <button id="del-${user.id}" style="background:red;color:white;border:none;padding:6px;cursor:pointer;">delete</button>
        <button id="his-${user.accountNo}" style="background:#555;color:white;border:none;padding:4px;cursor:pointer;">History</button>
         </div>`;
        container.appendChild(div)
        document.getElementById(`dep-${user.accountNo}`).onclick=()=>deposit(user);
        document.getElementById(`with-${user.accountNo}`).onclick=()=>withdraw(user);
        document.getElementById(`del-${user.id}`).onclick=()=>deleteAccount(user.id);
        document.getElementById(`his-${user.accountNo}`).onclick = () => showHistory(user);
    });
}
//task-2
function filterUsers() {
  const searchText = document.getElementById("search").value.toLowerCase();
  const city = document.getElementById("branch").value;

  const filtered = allusers.filter(user =>
    user.name.trim().toLowerCase().includes(searchText) &&
    (city === "" || user.address.city === city)
  );
  saveToStorage();
  display(filtered);
}
document.getElementById("search").addEventListener("input", filterUsers);
document.getElementById("branch").addEventListener("change", filterUsers);
//task-3
function deposit(user) {
  const amount = Number(prompt("Enter deposit amount"));
  if (amount > 0) {
    user.balance += amount;
    user.transactions.push({
      type: "DEPOSIT",
      amount: amount,
      time: new Date().toLocaleString()
    });
    saveToStorage();
    display(allusers);
  }
}
//task-3 and 8
function withdraw(user) {
  const amount = Number(prompt("Enter withdraw amount"));
  if (amount > user.balance) {
    alert("Insufficient balance");
    return;
  }
  if (amount > 0) {
    user.balance -= amount;
    if (user.balance < 5000) {
      user.balance -= 200;
      alert("Minimum balance breached! Rupees.200 penalty applied.");
      user.transactions.push({
        type: "PENALTY",
        amount: 200,
        time: new Date().toLocaleString()
      });
    }
    user.transactions.push({
      type: "WITHDRAW",
      amount: amount,
      time: new Date().toLocaleString()
    });
    saveToStorage();
    display(allusers);
  }
}
//task-4
document.getElementById("addForm").addEventListener("submit", async function(e){
  e.preventDefault();
  const newUser = {
    accountNo:document.getElementById("accountNo").value,
    name: document.getElementById("name").value,
    email: document.getElementById("email").value,
    address: {
      city: document.getElementById("city").value
    }
  };
  try {
    const response = await fetch(
      "https://69663546f6de16bde44c915b.mockapi.io/api/policy/bankusers",
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json"
        },
        body: JSON.stringify(newUser)
      }
    );
    const savedUser = await response.json();
    allusers.push({
      ...savedUser,
      balance: 10000,
      transactions: []
    });
    saveToStorage();
    display(allusers);
    e.target.reset();
  }
  catch(error){
    console.error("Error creating account:", error);
  }
});
//task-5
async function deleteAccount(id) {
  if (!confirm("Are you sure you want to delete this account?")) return;

  try {
    await fetch(
      `https://69663546f6de16bde44c915b.mockapi.io/api/policy/bankusers/${id}`,
      { method: "DELETE" }
    );
    allusers = allusers.filter(user => user.id !== id);
    saveToStorage();
    display(allusers);
  }
  catch (error) {
    console.error("Error deleting account:", error);
  }
}
//task-6 in html-css
//task-7
function showHistory(user) {
  if (user.transactions.length === 0) {
    alert("No transactions yet");
    return;
  }
  let history = user.transactions
    .map(t => `${t.type} ₹${t.amount} on ${t.time}`)
    .join("\n");
  alert(history);
}
getUsers();
//task-9
function saveToStorage() {
  localStorage.setItem("bankAccounts", JSON.stringify(allusers));
}
function loadFromStorage() {
  const data = localStorage.getItem("bankAccounts");
  return data ? JSON.parse(data) : null;
}
//task-10
function sortByBalance() {
  allusers.sort((a, b) => b.balance - a.balance);
  display(allusers);
  saveToStorage();
}
document.getElementById("sortBalance").addEventListener("click", sortByBalance);
function calculateTotalBalance() {
  const total = allusers.reduce((sum, user) => sum + user.balance, 0);
  alert("Total Bank Balance: Rupees." + total);
}
document.getElementById("totalBalance").addEventListener("click", calculateTotalBalance);