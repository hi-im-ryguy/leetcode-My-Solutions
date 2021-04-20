/**
 * @param {string} digits
 * @return {string[]}
 */
 var letterCombinations = function(digits) {
    
    var output = [];
    
    if (digits.length == 1) {
        for(var i = 0; i < digit_to_letter_enum[digits[0]].length; i++) {
            output[i] = digit_to_letter_enum[digits[0]][i];
        }
    }
    
    
    
    else if (digits.length > 1) {
        var last_digit = digits.substring(digits.length - 1);
        digits = digits.slice(0, -1);
        var datboi = letterCombinations(digits);
        
        for (var i = 0; i < datboi.length; i++) {
            
            var new_array = [];
            
            for (var j = 0; j < digit_to_letter_enum[last_digit].length; j++) {
                new_array[j] = datboi[i] + digit_to_letter_enum[last_digit][j];
            }
            
            output = output.concat(new_array);
        }
    }
    
    
    return output;
};

const digit_to_letter_enum = {
    2: "abc",
    3: "def",
    4: "ghi",
    5: "jkl",
    6: "mno",
    7: "pqrs",
    8: "tuv",
    9: "wxyz"
};
