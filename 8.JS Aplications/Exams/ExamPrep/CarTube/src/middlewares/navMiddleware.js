import {render} from "../../node_modules/lit-html/lit-html.js"

const navigationElement = document.querySelector('container .nav');


import { navigationRenderer } from "../views/navView.js";

export function navigationMiddleware(ctx,next) {
    render(navigationRenderer(ctx), navigationElement);

    next();
}


