main :: IO()
main = do
 putStr "Enter triangle"
 input<-getLine
 let n = read input :: Int
 printTr n

 
printTr :: Int -> IO()
printTr 0 = putStr ""
printTr n = do
  printTr (n-1)
  putStrLn (replicate n '*')