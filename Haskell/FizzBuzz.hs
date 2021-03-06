fizzbuzz :: Int -> String
fizzbuzz x
    | x `mod` 3  == 0 = "Fizz"
    | x `mod` 5  == 0 = "Buzz"
    | x `mod` 15 == 0 = "FizzBuzz"
    | otherwise       = show x

main = mapM(putStrLn . fizzbuzz) [1..100]
