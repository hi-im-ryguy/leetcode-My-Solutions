/**
 * @param {string} s
 * @return {number} longestLength
 */
var lengthOfLongestSubstring = function(s) {
    var longestLength = 0;
    
    // Because Javascript doesn't treat strings as a array of chars, we have to make our own
    // EXAMPLE: "asdf" = ['a', 's', 'd', 'f']
    var stringAsCharArray = s.split("");
    
    // I will now create a "Queue"
    // Javascript doesn't have a native "Queue" object, so I will just use an array, and push() and shift() accordingly.
    var uniqueCharactersOnly = [];
    
    // Let's iterate through each letter of the string
    stringAsCharArray.forEach(function(letter) {
        
        // Here, I'm checking if 
        // I want to make sure to remove all characters preceding the duplicate character to be added, including the letter itself
        while (uniqueCharactersOnly.includes(letter)) {
            uniqueCharactersOnly.shift();
        }
        
        // Add the letter to our "Queue" object
        uniqueCharactersOnly.push(letter);
        
        // Because our goal is to only provide the biggest length of any substring without repeating characters within a string,
        // We can just increment our longestLength field whenever the uniqueCharacetersOnly array exceeds it, and return longestLength
        if (uniqueCharactersOnly.length > longestLength) {
            longestLength = uniqueCharactersOnly.length
        }
    });
    
    return longestLength;
};
