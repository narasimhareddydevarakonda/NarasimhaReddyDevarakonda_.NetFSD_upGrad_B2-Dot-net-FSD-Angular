let tasks = [];

export const addTaskCallback = (task, callback) => {
  setTimeout(() => {
    tasks.push(task);
    callback(null, `Task "${task}" added`);
  }, 500);
};

export const deleteTaskCallback = (task, callback) => {
  setTimeout(() => {
    const index = tasks.indexOf(task);
    if (index === -1) {
      callback(`Task "${task}" not found`);
    } else {
      tasks.splice(index, 1);
      callback(null, `Task "${task}" deleted`);
    }
  }, 500);
};

export const listTasksCallback = (callback) => {
  setTimeout(() => {
    callback(null, [...tasks]);
  }, 500);
};

export const addTaskPromise = (task) =>
  new Promise((resolve) => {
    setTimeout(() => {
      tasks.push(task);
      resolve(`Task "${task}" added`);
    }, 500);
  });

export const deleteTaskPromise = (task) =>
  new Promise((resolve, reject) => {
    setTimeout(() => {
      const index = tasks.indexOf(task);
      if (index === -1) {
        reject(`Task "${task}" not found`);
      } else {
        tasks.splice(index, 1);
        resolve(`Task "${task}" deleted`);
      }
    }, 500);
  });

export const listTasksPromise = () =>
  new Promise((resolve) => {
    setTimeout(() => {
      resolve([...tasks]);
    }, 500);
  });

export const addTaskAsync = async (task) => {
  const message = await addTaskPromise(task);
  return message;
};

export const deleteTaskAsync = async (task) => {
  const message = await deleteTaskPromise(task);
  return message;
};

export const listTasksAsync = async () => {
  const allTasks = await listTasksPromise();
  return allTasks;
};