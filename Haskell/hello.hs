main::IO
main=do
  putStrLn "hello,world"
  line1<-getLine
  putStrLn(line1++"!="++show (fact n))