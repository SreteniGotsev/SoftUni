import { html, nothing } from "../../node_modules/lit-html/lit-html.js"

const loggedUser = () => 
    html`
<div id="profile">
<a>Welcome username</a>
<a href="/my-listings">My Listings</a>
<a href="/create">Create Listing</a>
<a href="/logout">Logout</а>
</div>`



const guestUser = () => html`
<div id="guest">
    <a href="/login">Login</a>
    <a href="/register">Register</a>
</div>`



const navigationTemplate = () => 
    html`
<nav>
<a class="active" href="/">Home</a>
<a href="/listings">All Listings</a>
<a href="/search">By Year</a>

${guestUser()}

</nav>`

//${user ? loggedUser() : guestUser()}

export const navigationRenderer = (ctx) => {

     return navigationTemplate();
}