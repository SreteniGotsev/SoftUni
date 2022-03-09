import { navigationMiddleware } from "./middlewares/navMiddleware.js"
import { renderMiddleware } from "./middlewares/renderMiddleware.js"

import page from "../node_modules/page/page.jms"

page(navigationMiddleware)
//page(renderMiddleware)

page('/', () => console.log('something'))
page.start()