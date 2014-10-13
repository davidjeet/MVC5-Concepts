/// <reference path="../app/app.js" />
/// <reference path="../jasmine.js" />


describe("Calculator", function () {
    
    it("should add two bloody positive numbers!", function () {
        var result = window.app.addNumbers(4, 5);

        expect(result).toBe(9);
    });
});