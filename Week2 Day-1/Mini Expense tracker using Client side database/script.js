var db;

function initDB() {
    var request = indexedDB.open("ExpenseDB", 1);

    request.onerror = function (event) {
        alert("Database error: " + event.target.errorCode);
    };

    request.onupgradeneeded = function (event) {
        db = event.target.result;

        if (!db.objectStoreNames.contains("expenses")) {
            var objectStore = db.createObjectStore("expenses", {
                keyPath: "id",
                autoIncrement: true
            });

            objectStore.createIndex("title", "title", { unique: false });
            objectStore.createIndex("amount", "amount", { unique: false });
            objectStore.createIndex("date", "date", { unique: false });
        }
    };

    request.onsuccess = function (event) {
        db = event.target.result;
    };
}

function addExpense() {
    var title = document.getElementById("title").value;
    var amount = document.getElementById("amount").value;
    var date = document.getElementById("date").value;

    var transaction = db.transaction(["expenses"], "readwrite");
    var store = transaction.objectStore("expenses");

    var expense = {
        title: title,
        amount: amount,
        date: date
    };

    var request = store.add(expense);

    request.onsuccess = function () {
        alert("Expense added successfully");
        viewExpenses();
    };

    request.onerror = function () {
        alert("Error adding expense");
    };

    transaction.onerror = function () {
        alert("Transaction failed");
    };
}

function viewExpenses() {
    var list = document.getElementById("expenseList");
    list.innerHTML = "";

    var transaction = db.transaction(["expenses"], "readonly");
    var store = transaction.objectStore("expenses");

    var request = store.openCursor();

    request.onsuccess = function (event) {
        var cursor = event.target.result;
        if (cursor) {
            var li = document.createElement("li");
            li.innerHTML =
                "ID: " + cursor.value.id +
                " | Title: " + cursor.value.title +
                " | Amount: " + cursor.value.amount +
                " | Date: " + cursor.value.date;
            list.appendChild(li);
            cursor.continue();
        }
    };

    request.onerror = function () {
        alert("Error fetching expenses");
    };

    transaction.onerror = function () {
        alert("Transaction failed");
    };
}

function deleteExpense() {
    var id = prompt("Enter Expense ID to delete:");

    if (!id) return;

    var transaction = db.transaction(["expenses"], "readwrite");
    var store = transaction.objectStore("expenses");

    var request = store.delete(Number(id));

    request.onsuccess = function () {
        alert("Expense deleted successfully");
        viewExpenses();
    };

    request.onerror = function () {
        alert("Error deleting expense");
    };

    transaction.onerror = function () {
        alert("Transaction failed");
    };
}