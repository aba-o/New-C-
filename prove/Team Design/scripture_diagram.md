```mermaid

classDiagram

class Program {
    +Main(string[] args)
}

class Scripture {
    -Reference _reference
    -List~Word~ _words
    +HideRandomWords()
    +GetDisplayText()
    +IsCompletelyHidden()
}

class Reference {
    -string _book
    -int _chapter
    -int _verse
    -int _endVerse
    +GetDisplayText()
}

class Word {
    -string _text
    -bool _isHidden
    +Hide()
    +Show()
    +GetDisplayText()
}

Program --> Scripture
Scripture --> Reference
Scripture --> Word