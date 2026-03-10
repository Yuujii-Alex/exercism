#include "raindrops.h"

namespace raindrops {

// TODO: add your solution here

    
    std::string convert(int number) 
    {
        std::string raindropString;

        if (number % 3 == 0) {
            raindropString += "Pling";
        }
        if (number % 5 == 0) {
            raindropString += "Plang";
        }
        if (number % 7 == 0) {
            raindropString += "Plong";
        } 
        if (raindropString.empty()) {
            return std::to_string(number);
        }

        return raindropString;
    }
    
    
}  // namespace raindrops
