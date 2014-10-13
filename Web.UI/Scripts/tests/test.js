/// <reference path="../app/app.js" />


test("adding 1 + 3 for giggles", function () {
    var result = window.app.addNumbers(1, 3);
    ok(result === 4, "should be 4");
});

test("Zeroth  QUnit test", function () {
    var x = 6;
    equal(x, 6, "Should be 6");
});