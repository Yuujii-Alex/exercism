#include <string>

namespace log_line {
std::string message(std::string line) {
    auto pos = line.find(": ");
    return line.substr(pos + 2);
}


std::string log_level(std::string line) {

    // find the brackets
    auto start = line.find('[');
    auto end = line.find(']');

    // extract the substring
    std::string level = line.substr(start + 1, end - start - 1);
    
    return level;
}

std::string reformat(std::string line) {
    // return the reformatted message
    auto start = line.find('[');
    auto end = line.find(']');

    std::string level = line.substr(start+1, end-start-1);

    auto pos = line.find(": ");
    std::string message = line.substr(pos + 2) + " (" + level + ")";
    
    return message;
}
}  // namespace log_line
