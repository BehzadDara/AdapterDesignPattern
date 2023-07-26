using AdapterDesignPattern;

var circle = new Circle();
var circleAdapter = new CircleAdapter(circle);
circleAdapter.Move();