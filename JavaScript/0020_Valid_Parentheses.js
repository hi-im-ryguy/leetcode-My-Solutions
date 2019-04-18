/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    
    const openParenthesis = {
        "(": ")",
        "{": "}",
        "[": "]" 
    }
    
    var stringToCharArray = s.split("");
    var parenthesisStack =  [];
    for (let i = 0; i < stringToCharArray.length; i++) {
        if (stringToCharArray[i] in openParenthesis) {
            parenthesisStack.push(stringToCharArray[i]);
        } else if (Object.values(openParenthesis).indexOf(stringToCharArray[i]) > -1) {
            if (parenthesisStack.pop() !== Object.keys(openParenthesis).find(key => openParenthesis[key] === stringToCharArray[i])) {
                return false;
            }
        } else {
            return false;
        }
    }
    return true ? parenthesisStack.length === 0 : false;
};
    
var getKeyByValue = function(s) {
    
}
