let editId = null;
const postForm = document.getElementById("postForm");
const editForm = document.getElementById("editForm");
postForm.addEventListener("submit", async (e) => {
  e.preventDefault();
  await fetch(
    "https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata",
    {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        name: name.value,
        type: type.value,
        premium: premium.value,
        duration: duration.value,
        status: status.value
      })
    }
  );
  postForm.reset();
  getPolicies();
});
async function getPolicies() {
  const res = await fetch(
    "https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata"
  );
  const data = await res.json();
  cards.innerHTML = data
    .map(
      (p) => `
      <div class="bg-white p-4 rounded shadow">
        <h3 class="font-bold">${p.name}</h3>
        <p>Type: ${p.type}</p>
        <p>Premium: ${p.premium}</p>
        <p>Duration: ${p.duration}</p>
        <p>Status: ${p.status}</p>
        <div class="flex gap-2 mt-2">
          <button onclick="editPolicy('${p.id}')"
            class="bg-yellow-500 text-white px-2 py-1 rounded">Edit</button>
          <button onclick="deletePolicy('${p.id}')"
            class="bg-red-500 text-white px-2 py-1 rounded">Delete</button>
        </div>
      </div>
    `
    )
    .join("");
}
async function editPolicy(id) {
  const res = await fetch(
    `https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata/${id}`
  );
  const p = await res.json();
  editName.value = p.name;
  editType.value = p.type;
  editPremium.value = p.premium;
  editDuration.value = p.duration;
  editStatus.value = p.status;
  editId = id;
  postForm.classList.add("hidden");
  editForm.classList.remove("hidden");
};
editForm.addEventListener("submit", async (e) => {
  e.preventDefault();
  await fetch(
    `https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata/${editId}`,
    {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        name: editName.value,
        type: editType.value,
        premium: editPremium.value,
        duration: editDuration.value,
        status: editStatus.value
      })
    }
  );
  editId = null;
  editForm.reset();
  editForm.classList.add("hidden");
  postForm.classList.remove("hidden");
  getPolicies();
});
deletePolicy = async function (id) {
  await fetch(
    `https://69663546f6de16bde44c915b.mockapi.io/api/policy/policydata/${id}`,
    { method: "DELETE" }
  );
  getPolicies();
};
getPolicies();
