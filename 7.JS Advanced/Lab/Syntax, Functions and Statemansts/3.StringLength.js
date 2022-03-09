function Solve(text1, text2, text3){
    let text1Length = text1.length
    let text2Length = text2.length
    let text3Length = text3.length

    let sumlength = text1Length + text2Length + text3Length

    let averageLength = sumlength / 3

    console.log(sumlength);
    console.log(Math.floor(averageLength));
}