import { render } from "../../node_modules/lit-html/lit-html.js"

const bodyElement = document.querySelector('main');

export const renderMiddleware = (ctx, next) => {
    ctx.render = (templateResult) => {
        render(templateResult, bodyElement);
    }

    next();

}