function Money (v) {	  
    this.value = this.numval(v);
 }
 Money.prototype.numval = function (v) {
    if ( v instanceof Money) {
        return v.value;
    }else{
        if (typeof v == 'undefined') {
            return 0;
        }
        if (!isFinite(v)) {
            alert('无效的数值: '+v);
            return 0;
        }
        var n = isNaN(v) ? 0 : new Number(v);
        return  Math.round( n * 1000 );
    }    
 }
 Money.prototype.add = function(v) { //加
    this.value += this.numval(v);
    return this;
 }
 Money.prototype.sub = function (v ) {//减
    this.value -= this.numval(v);
    return this;
 }
 Money.prototype.mul = function (v) {//乘
    this.value *=  (this.numval(v)/1000);
    return this;
 }
 Money.prototype.mul2 = function (v) {//乘
    this.value *= this.numval(v);
    this.value /= 1000;
    return this;
 }
 Money.prototype.div = function (v) {//除
    var n=  this.numval(v);
    if (n == 0) {
        this.value /= (n/1000);
    }else{
        alert('被除数不能为0');
    }
    return this;
 }
  Money.prototype.div2 = function (v) {//除
    var n=  this.numval(v);
    if (n == 0) {
        this.value /= n;
    }else{
        alert('被除数不能为0');
    }
    return this;
 }
 Money.prototype.toDecimal = function() {
    return Math.round(this.value/10)/100;
 }
 Money.prototype.toString = function () {
    return this.toDecimal() + '';
 }
 Money.prototype.getVal = function(){
    return this.toInt();
 }
 Money.prototype.toInt = function() {
    return Math.round(this.value/1000);
 }