CREATE TABLE `books` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `author` LONGTEXT,
  `launch_date` DATETIME(6) NOT NULL,
  `price` DECIMAL(65,2) NOT NULL,
  `title` LONGTEXT
);
