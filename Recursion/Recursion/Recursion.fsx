let rec fact = function
    |1 ->1
    |n ->n * fact(n - 1)

fact 4

//Using else if statement

let rec fact2 n = 
    if 
        n <= 1 then 1
    else 
        n * fact2(n - 1)

fact2 4
fact2 1