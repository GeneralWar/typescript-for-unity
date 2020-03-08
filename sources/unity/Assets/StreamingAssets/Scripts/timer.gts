"use strict";
var exports = {};
var __extends = (this && this.__extends) || (function () {
var extendStatics = function (d, b) {
extendStatics = Object.setPrototypeOf ||
({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
return extendStatics(d, b);
}
return function (d, b) {
extendStatics(d, b);
function __() { this.constructor = d; }
d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
})();
Object.defineProperty(exports, "__esModule", { value: true });
var Timer = (function (_super) {
__extends(Timer, _super);
function Timer() {
var _this = _super !== null && _super.apply(this, arguments) || this;
_this.elapsedTime = 0;
_this.ticker = 0;
return _this;
}
Object.defineProperty(Timer.prototype, "elapsed", {
get: function () {
return this.elapsedTime;
},
enumerable: true,
configurable: true
});
Timer.prototype.Awake = function () {
this.label = this.gameObject.GetComponent(UnityEngine.UI.Text);
};
Timer.prototype.Update = function () {
var parameters = [];
for (var _i = 0; _i < arguments.length; _i++) {
parameters[_i] = arguments[_i];
}
this.elapsedTime += UnityEngine.Time.deltaTime;
if (this.elapsedTime > 1) {
++this.ticker;
if (this.ticker > 3) {
var self_1 = this.gameObject.GetComponent(Timer);
UnityEngine.Object.Destroy(self_1);
return;
}
var message = "Timer ticker : " + this.ticker;
this.label.text = message;
console.log(message);
this.elapsedTime -= 1;
}
};
Timer.prototype.OnDestroy = function () {
this.label.text = "Timer has been destroyed ...";
};
return Timer;
}(General.Behaviour));
exports.Timer = Timer;
exports;