# Homework1

Group A results:

1) Doubles 37389 ticks, Floats 40128 ticks
Floats added sligtly slower than doubles likely because floats are more complex as the range
they represent is dynamic compared to doubles which have a fixed range


Group B results:

3) Manual square 43634 ticks, Function square 228857 ticks, Function square root 38790 ticks
The manual square root was much faster than the function this suggests that the function
is doing someting else in the background making it less efficent. My guess is that it has
to do with some kind of syntax or data type check.

4) Manual Sin 430190 ticks, Function Sin 106255 ticks, Function Cos 110423 ticks
The manual sin calculation is much slower suggesting that the taylor series approximation is
extremely ineficent compared to the built in function.

5) Manual Exponent 439979 ticks, Function Exponent 364360 ticks, Function Log 78142 ticks
The function exponent calculation is faster than the manual function this tells us again
that the taylor series calculations are much less efficent.
