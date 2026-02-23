function saveNote() {
    var note = document.getElementById("noteArea").value;
    localStorage.setItem("dailyNote", note);
    alert("Note saved successfully!");
}

function loadNote() {
    var savedNote = localStorage.getItem("dailyNote");
    if (savedNote !== null) {
        document.getElementById("noteArea").value = savedNote;
    }
}

function clearNote() {
    localStorage.removeItem("dailyNote");
    document.getElementById("noteArea").value = "";
    alert("Note cleared!");
}