const pizzaUni = require(`./pizzaPlace.js`)
const {expect} = require('chai')

describe("Pizza place", () => {
    describe("MakeAnOrder", () => {

        it('Should return a confirmation message if there is pizza ordered', () => {
           let orderObj = {
               orderedPizza: 'Margaritta'
           }

           expect(pizzaUni.makeAnOrder(orderObj)).to.equal(`You just ordered ${orderObj.orderedPizza}`);
            
        });

        it('Should return a confirmation message for ordering pizza and drink', () =>{
            let orderObj = {
                orderedPizza: 'Margaritta',
                orderedDrink: 'Coke'
            }
 
            expect(pizzaUni.makeAnOrder(orderObj)).to.equal(`You just ordered ${orderObj.orderedPizza} and ${orderObj.orderedDrink}`);
        });

        it('Should throw if there is no pizza in the order', () =>{
            let orderObj = {
                
                orderedDrink: 'Coke'
            }
 
            expect(pizzaUni.makeAnOrder(orderObj)).to.throw('You must order at least 1 Pizza to finish the order.')
        });
    })
});