var Sayings;
(function (Sayings) {
    var Greeter = (function () {
        //joke: number;
        function Greeter(message) {
            this.greeting = message;
        }
        Greeter.prototype.greet = function () {
            return "Hello, " + this.greeting;
        };

        Greeter.prototype.greet2 = function (tmp) {
            return 3 * tmp;
        };
        return Greeter;
    })();
    Sayings.Greeter = Greeter;
})(Sayings || (Sayings = {}));
var greeter = new Sayings.Greeter("world");

var button = document.createElement('button');
button.textContent = "Say Hello";
button.onclick = function () {
    alert(greeter.greet());

    var joke = 7;
    alert(greeter.greet2(joke));
};

document.body.appendChild(button);
//# sourceMappingURL=HelloWorld.js.map
