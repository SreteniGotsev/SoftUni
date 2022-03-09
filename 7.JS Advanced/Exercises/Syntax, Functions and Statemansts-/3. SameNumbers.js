function Solve (num){

    let isSame = true;
    let nums = String(num);
    let sum = 0;
    for (let index = 0; index < nums.length - 1; index++) {

        if(nums[index] === nums[index+1]){
        isSame = true;
        } else {
            isSame = false;            
        }
        sum+=Number(nums[index]);
    }
    sum+=Number(nums[nums.length-1]);
    console.log(isSame);
    console.log(sum)
}

