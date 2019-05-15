let rec fact = function
    |0 -> 1
    |1 -> 1
    |n ->n * fact(n - 1)

fact 4

//Using else if statement

let rec fact2 n = 
    if n <= 1 then 1
    else n * fact2(n - 1)

fact2 4
fact2 1

let rec fib = function
    |0 -> 0I
    |1 -> 1I
    |n -> fib(n - 1) + fib(n - 2)

fib 4

//From class
// Append

let rec append = function
    |([], ys) -> ys
    //|(xs, []) -> xs I dont need it because xs is getting smaller
    |(x::xs, ys) -> x :: append (xs, ys);;

append ([1;3;4],[4;5;6]);;



