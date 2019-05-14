//Problem 16

let rec gcd = function 
    | (a, 0) -> a
    | (a, b) -> gcd(b, a % b);;

let (.+) (a, b) (c, d) = 
    let x = (a * d) + (b * c)
    let y = (b * d)
    let z = gcd(a, b)
    (x/c, y/c);;
 
let (.*) (a, b) (c, d) = 
    let x = (a * c)
    let y = (b * d)
    let z = gcd(x, y)
    (x/c, y/c);;

(1, 2) .+ (1, 2);;
(1,2) .+ (2,3) .* (3,7);;

//Problem 17

let revlists xs = 
    List.map (fun x -> List.rev x) xs;;

revlists [[0;1;1];[3;2];[];[5]];;

//Problem 18

let rec interleave = function
    |([], ys) -> ys
    |(xs, []) -> xs
    |(x::xs, y::ys) -> x :: y  :: interleave(xs, ys);;

interleave ([1;2;3],[4;5;6]);;

//Problem 19
//let rec gencut = function 
    //|n , x::xs ->
    //let(left, right) = gencut ((n-1), xs)
    //(x::left, right)

//let cut list = 
    //gencut (length/2) list

fun f -> String.length(f "cat");;
fun f -> f (f "cat");;
fun x y -> x + " " + y;;
