function Solve(firstNum, secondNum){
        while (secondNum > 0) {
            let holder = secondNum;
            secondNum = firstNum%secondNum;
            firstNum= holder;
        }
        return firstNum
    }

