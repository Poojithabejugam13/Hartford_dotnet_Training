//1.Change the dashboard title text to “Customer Insurance Overview”
document.getElementById("pageTitle").textContent = "Customer Insurance Overview";
//2.– Select by Tag Name
//Select all <li> elements and:
//Add a border
//Log the total number of customers
li_elements=document.getElementsByTagName("li")
for(i=0;i<li_elements.length;i++){
    li_elements[i].style.border="1px solid black"
}
console.log("Total number of customers:",li_elements.length);
//3.Select all .policy elements and:
//Add highlight class
//Change text color to blue
policy=document.getElementsByClassName("policy")
for(i=0;i<policy.length;i++){
    policy[i].classList.add("highlight")        
    policy[i].style.color="blue"
}
//4 Select using CSS Selectors
// Select the first customer only
// Select all customers
// Mark the last customer as active\
firstCustomer=document.querySelector(".customer")
allCustomers=document.querySelectorAll(".customer")
lastCustomer=allCustomers[allCustomers.length-1]
lastCustomer.classList.add("active")
//5.– HTML Object Collections
// Using document collections:
// Count number of forms
// Get number of images
// Change text of all links to “More Info”
console.log("Number of forms:",document.forms.length);
console.log("Number of images:",document.images.length);
for(i=0;i<document.links.length;i++){
    document.links[i].textContent="More Info"
}
//6. Add a new customer dynamically and observe:
// Which selections update automatically?
// Which don't?
li=document.createElement("li")
li.textContent="Poojitha-Health"
ul=document.getElementById("customerList")
li.classList.add("customer")
ul.appendChild(li)
console.log("Total number of customers:",li_elements.length);

console.log(firstCustomer,allCustomers);
// The selection using getElementsByTagName() and getElementsByClassName() adnd getElementById()
// updates automatically because they return LIVE HTMLCollections.

// The selection using querySelectorAll()
// does not update automatically because it returns a STATIC NodeList.

//7. Attribute-Based Selection
// Select only input fields whose type is "text" using CSS selectors and:
// Add a yellow background
// Add placeholder text: "Enter Full Name"
textfields=document.querySelectorAll('input[type="text"]')
for(i=0;i<textfields.length;i++){
    textfields[i].style.backgroundColor="yellow"
    textfields[i].setAttribute("placeholder","Enter Full Name")
}
// 8.Multiple Class Selection
// Select all elements that have both customer and active classes and:
// Change text color to dark green
// Add text (Priority Customer) at the end
priorityCustomers=document.querySelectorAll('.customer.active')
for(i=0;i<priorityCustomers.length;i++){
    priorityCustomers[i].style.color="darkgreen"
    priorityCustomers[i].textContent+=" (Priority Customer)"
}
//9.Descendant vs Child Selector
// Select all <li> elements inside #customerList using a descendant selector
// Select only direct child <li> using a child selector
// Log the difference in console.
descendantLi=document.querySelectorAll('#customerList li')
childLi=document.querySelectorAll('#customerList > li')
console.log("Descendant <li> elements:",descendantLi);
console.log("Child <li> elements:",childLi);
//descendant selector selects all <li> elements that are descendants of #customerList, including nested ones.
//child selector selects only the direct child <li> elements of #customerList.
//10. Even / Odd Selection (CSS Pseudo Selectors)
//  Using querySelectorAll():
//  Highlight even customers in light gray
//  Highlight odd customers in light blue
//  Hint:nth-child()
evenCustomers=document.querySelectorAll('#customerList li:nth-child(even)')
oddCustomers=document.querySelectorAll('#customerList li:nth-child(odd)')       
for(i=0;i<evenCustomers.length;i++){
    evenCustomers[i].style.backgroundColor="lightgray"
}               
for(i=0;i<oddCustomers.length;i++){
    oddCustomers[i].style.backgroundColor="lightblue"
}
//11.
//  Form Elements Collection
// Using HTML form object model:
// Access the enquiry form
// Log all input field names
// Disable the submit button
//  Hint: document.forms["formId"].elements       

let enqform=document.forms["enquiryForm"].elements
for(i=0;i<enqform.length;i++){
    if(enqform[i].type==="submit"){
        enqform[i].disabled=true
    }
    else{
    console.log(`${enqform[i].name}`);
    }
}
// 12.Select policies using:JavaScript 
// getElementsByClassName
//  querySelectorAll
//  Dynamically add a new policy
//  Observe which collection updates automatically
let poli=document.getElementsByClassName("policy")
console.log(poli.length)
let poli2=document.querySelectorAll('.policy')
console.log(poli2.length)

let newPolicy=document.createElement("p")
newPolicy.classList.add("policy")
newPolicy.textContent="Travel Insurance"
document.body.appendChild(newPolicy)
console.log(`after newpolicy added,${poli.length}`)
console.log(`after new policy added:${poli2.length}`)
//The collection obtained using getElementsByClassName() updates automatically because it returns a LIVE HTMLCollection.
//The collection obtained using querySelectorAll() does not update automatically because it returns a STATIC NodeList.

//13. Text Content Filtering
//Select all customers and:
//Highlight customers whose policy includes "Life"
//Hide customers whose policy includes "Vehicle"
//Hint: textContent.includes()
allCustomers=document.getElementsByClassName("customer")
for(i=0;i<allCustomers.length;i++){
    if(allCustomers[i].textContent.includes("Life")){
        allCustomers[i].classList.add("highlight")
    }
    if(allCustomers[i].textContent.includes("Vehicle")){
        allCustomers[i].style.display="none"
    }
}
//14.Closest & Parent Traversal
//When clicking any customer <li>:
//Find the nearest <ul>
//Add a border to it
//Hint: closest()
allCustomers=document.getElementsByClassName("customer")
for(i=0;i<allCustomers.length;i++){
    allCustomers[i].addEventListener("click",function(){                
        let nearestUl=this.closest("ul")
        nearestUl.style.border="2px solid red"                
    })
}   
//15.Complex Selector Challenge Select:
//All policy <p> elements except the first one and:
//Change font style to italic
//Prefix text with "✔ "
//Hint: :not() and :first-child

let policies=document.querySelectorAll('body p.policy:not(:first-of-type)')
console.log(policies)
for(i=0;i<policies.length;i++){
    policies[i].style.fontStyle="italic"
    policies[i].textContent="✔ "+policies[i].textContent
}

