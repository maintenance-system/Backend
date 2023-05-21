# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import PyPDF2


def readPDF():
    with open(r'H:\Final Project\בטיחות.pdf', 'rb') as file:
        pdf = PyPDF2.PdfReader(file)
        num_pages = len(pdf.pages)

        text = ''
        for page_num in range(num_pages):
            page = pdf.pages[page_num]
            text += page.extract_text().encode('utf-8', errors='ignore').decode('utf-8')
            #-->>>
            #print(text)
        return text


def writeToText(text : str):
    with open(r'H:\Final Project\text111.txt', 'w+', encoding='utf-8') as file:
        file.write(text)






# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print(readPDF())
    text = readPDF()
    writeToText(text)

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
