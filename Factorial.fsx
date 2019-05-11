let rec fact x = 
    if x < 1 then 1
    else x * fact (x - 1);;

fact 7


let rec fact_2  = function
    | n when n < 1 -> 1
    | n -> n * fact_2(n - 1);;

fact_2 7
#time;;

fact_2 7
fact_2 8