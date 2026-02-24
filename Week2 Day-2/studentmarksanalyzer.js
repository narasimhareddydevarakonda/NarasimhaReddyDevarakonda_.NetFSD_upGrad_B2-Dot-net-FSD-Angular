const studentMarks = [78, 85, 62, 90, 55, 47, 88];

const calculateTotal = (marks) =>
  marks.reduce((total, mark) => total + mark, 0);

const calculateAverage = (marks) => {
  const total = calculateTotal(marks);
  return marks.length ? total / marks.length : 0;
};

const getResult = (average) => (average >= 50 ? "Pass" : "Fail");

const totalMarks = calculateTotal(studentMarks);
const averageMarks = calculateAverage(studentMarks);
const result = getResult(averageMarks);

console.log(`

Marks: ${studentMarks.join(", ")}

Total Marks: ${totalMarks}
Average Marks: ${averageMarks.toFixed(2)}
Result: ${result}

`);