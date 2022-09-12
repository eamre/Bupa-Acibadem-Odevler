const array = [1,2,4,5,6,7,9,11];
const target = 15;
let storage=[];

/*Solution 1 */
// let sumFunc = function(array, target) {
//     for (let i = 0; i < array.length; i++) {
//         for (let j = 0 ; j < array.length; j++) {
//             if (array[i] + array[j] == target) {
//                 return [i, j]
//             }
//         }
//     }
// };
//console.log(sumFunc(array,target));

/*Solution 2 */
let sumFunc2 = function(array, target) {
    const ind = new Map();

    for (let index = 0; index < array.length; index++) {
        const complement = target - array[index];

        if (ind.has(complement)) {
            storage.push([ind.get(complement), index]);
        }
        ind.set(array[index], index)
    }
    return storage;
};
console.log(sumFunc2(array,target));