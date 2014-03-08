module DenizenScript

type script = 
    | WorldScript of worldscript
    | AssignmentScript of assignmentscript
    | InteractScript of interactscript
    | BookScript of bookscript

type File = {
    Scripts: script list
}