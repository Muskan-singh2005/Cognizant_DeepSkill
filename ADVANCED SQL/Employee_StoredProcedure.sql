USE OnlineRetailStore;

-- STEP 1: CREATE TABLE
CREATE TABLE IF NOT EXISTS Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);

-- STEP 2: INSERT DATA
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John', 'Doe', 1, 50000, '2023-01-10'),
('Jane', 'Smith', 2, 60000, '2022-06-15'),
('Robert', 'Brown', 1, 55000, '2021-09-20'),
('Emily', 'Davis', 3, 70000, '2020-12-01');

-- STEP 3: STORED PROCEDURE (INSERT EMPLOYEE)
DELIMITER //

CREATE PROCEDURE sp_InsertEmployee (
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (p_FirstName, p_LastName, p_DepartmentID, p_Salary, p_JoinDate);
END //

DELIMITER ;

-- STEP 4: TEST PROCEDURE
CALL sp_InsertEmployee('Alex', 'Johnson', 2, 65000, '2024-01-01');

-- STEP 5: VIEW DATA
SELECT * FROM Employees;