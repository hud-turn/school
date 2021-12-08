#Final #4



start_str = "Supercalifragilisticexpialidocious"
result_str = ""
VOWELS = "AEIOU"
print(start_str)
for letter in start_str:
    if letter.upper() not in VOWELS:
        result_str += "-"
    else:
        result_str += letter
print(result_str)
input("Press Enter To Continue")
