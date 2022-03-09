
const {expect} = require('chai');

const cinema = {
    showMovies: function (movieArr) {

        if (movieArr.length == 0) {
            return 'There are currently no movies to show.';
        } else {
            let result = movieArr.join(', ');
            return result;
        }

    },
    ticketPrice: function (projectionType) {

        const schedule = {
            "Premiere": 12.00,
            "Normal": 7.50,
            "Discount": 5.50
        }
        if (schedule.hasOwnProperty(projectionType)) {
            let price = schedule[projectionType];
            return price;
        } else {
            throw new Error('Invalid projection type.')
        }

    },
    swapSeatsInHall: function (firstPlace, secondPlace) {
        if (!Number.isInteger(firstPlace) || firstPlace <= 0 || firstPlace > 20 ||
            !Number.isInteger(secondPlace) || secondPlace <= 0 || secondPlace > 20 ||
            firstPlace === secondPlace) {
            return "Unsuccessful change of seats in the hall.";
        } else {
            return "Successful change of seats in the hall.";
        }

    }
};


describe("Cinema tests", function() {
    
    describe("showMovies", function() {
        it('Should return empty show when there are no movies', function ()  {
            let movieArr = [];
            expect(cinema.showMovies(movieArr)).to.equal('There are currently no movies to show.')            
        });

        it('Should return an array with the movies.', function () {
            let movieArr = [`Ling Kong`, `The Tomorrow War`, `Joker`];
            expect(cinema.showMovies(movieArr)).to.equal(`${movieArr.join(', ')}`)            
        });
     });

    describe("ticketPrice", function()  {
        it('Should throw if projection is empty', function () {
            let projectionType = '';
            expect(cinema.ticketPrice(projectionType)).to.throws('Invalid projection type.');
        });

        it('Should treturn price 12.00', function () {
            let projectionType = 'Premiere';
            expect(cinema.ticketPrice(projectionType)).to.equal(12.00);
        });

        it('Should return price 7.50', function () {
            let projectionType = 'Normal';
            expect(cinema.ticketPrice(projectionType)).to.equal(7.50);
        });

        it('Should return price 5.50', function () {
            let projectionType = 'Discount';
            expect(cinema.ticketPrice(projectionType)).to.equal(5.50);
        });
     });

    describe("swapSeatsInHall", function ()  {
        it("TODO …", () => {
            
        });
     });
    
});
