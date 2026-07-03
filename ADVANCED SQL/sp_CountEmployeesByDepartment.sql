USE OnlineRetailStore;

-- STORED PROCEDURE: Count employees in a department
DELIMITER //

CREATE PROCEDURE sp_CountEmployeesByDepartment (
    IN p_DepartmentID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END //

DELIMITER ;
CALL sp_CountEmployeesByDepartment(1);
CALL sp_CountEmployeesByDepartment(2);