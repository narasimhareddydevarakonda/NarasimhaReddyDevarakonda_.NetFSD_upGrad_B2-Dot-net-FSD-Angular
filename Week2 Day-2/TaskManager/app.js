import {
  addTaskCallback,
  deleteTaskCallback,
  listTasksCallback,
  addTaskPromise,
  deleteTaskPromise,
  listTasksPromise,
  addTaskAsync,
  deleteTaskAsync,
  listTasksAsync
} from "./taskManager.js";

addTaskCallback("Study ES6", (err, message) => {
  if (!err) console.log(`Callback: ${message}`);
  listTasksCallback((_, tasks) =>
    console.log(`Tasks: ${tasks.join(", ")}`)
  );
});

addTaskPromise("Practice Promises")
  .then(message => {
    console.log(`Promise: ${message}`);
    return listTasksPromise();
  })
  .then(tasks => console.log(`Tasks: ${tasks.join(", ")}`))
  .catch(error => console.error(error));

const runAsyncVersion = async () => {
  try {
    console.log(`Async: ${await addTaskAsync("Master Async/Await")}`);
    console.log(`Async: ${await deleteTaskAsync("Study ES6")}`);
    const tasks = await listTasksAsync();
    console.log(`
------ Final Task List ------
${tasks.map((task, index) => `${index + 1}. ${task}`).join("\n")}
-----------------------------
`);
  } catch (error) {
    console.error(error);
  }
};

runAsyncVersion();