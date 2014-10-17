module Sayings {
    export class Greeter {
        greeting: string;
        //joke: number;


        constructor(message: string) {
            this.greeting = message;
        }

        greet() {
            return "!Hello, " + this.greeting;
        }

        greet2(tmp : number) {
            return 3 * tmp;
        }
    } 
}
var greeter = new Sayings.Greeter("world");


var button = document.createElement('button');
button.textContent = "Say Hello";
button.onclick = function () {
    alert(greeter.greet());

    var joke: number = 7;
    alert(greeter.greet2(joke));
};

document.body.appendChild(button); 