-- Tạo cơ sở dữ liệu
CREATE DATABASE TarotApp;
GO

-- Sử dụng cơ sở dữ liệu TarotApp
USE TarotApp;
GO

-- Tạo bảng Cards (Danh sách lá bài Major Arcana)
CREATE TABLE Cards (
    CardID INT IDENTITY(1,1) PRIMARY KEY,
    CardName NVARCHAR(50) NOT NULL,
    UprightMeaning NVARCHAR(MAX) NOT NULL,
    ReversedMeaning NVARCHAR(MAX) NOT NULL
);
GO

-- Tạo bảng Themes (Chủ đề)
CREATE TABLE Themes (
    ThemeID INT IDENTITY(1,1) PRIMARY KEY,
    ThemeName NVARCHAR(50) NOT NULL
);
GO

-- Tạo bảng Spreads (Phương thức trả bài 3 lá) mà không cần SpreadID
CREATE TABLE Spreads (
    Position INT PRIMARY KEY,      -- Sử dụng Position làm khóa chính
    PositionName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL
);
GO
ALTER TABLE Cards
ADD ImagePath NVARCHAR(255);

-- Tạo bảng Meanings (Ý nghĩa của lá bài theo chủ đề)
CREATE TABLE Meanings (
    MeaningID INT IDENTITY(1,1) PRIMARY KEY,
    CardID INT NOT NULL,
    ThemeID INT NOT NULL,
    UprightMeaning NVARCHAR(MAX) NOT NULL,
    ReversedMeaning NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (CardID) REFERENCES Cards(CardID),
    FOREIGN KEY (ThemeID) REFERENCES Themes(ThemeID)
);
GO

-- Tạo bảng Readings (Lịch sử đọc bài)
CREATE TABLE Readings (
    ReadingID INT IDENTITY(1,1) PRIMARY KEY,
    ThemeID INT NOT NULL,
    Card1ID INT NOT NULL,
    Card2ID INT NOT NULL,
    Card3ID INT NOT NULL,
    CreatedAt DATETIME NOT NULL,
    FOREIGN KEY (ThemeID) REFERENCES Themes(ThemeID),
    FOREIGN KEY (Card1ID) REFERENCES Cards(CardID),
    FOREIGN KEY (Card2ID) REFERENCES Cards(CardID),
    FOREIGN KEY (Card3ID) REFERENCES Cards(CardID)
);
GO

-- Tạo bảng ReadingDetail (Chi tiết của từng lần đọc bài)
CREATE TABLE ReadingDetail (
    ReadingDetailID INT IDENTITY(1,1) PRIMARY KEY,  -- Khóa chính tự động tăng
    ReadingID INT NOT NULL,                          -- ID của lần đọc bài
    CardID INT NOT NULL,                             -- ID của lá bài
    IsReversed BIT NOT NULL,                         -- Trạng thái ngược hay xuôi (0: Xuôi, 1: Ngược)
    FOREIGN KEY (ReadingID) REFERENCES Readings(ReadingID),  -- Liên kết với bảng Readings
    FOREIGN KEY (CardID) REFERENCES Cards(CardID)         -- Liên kết với bảng Cards
);
GO
select * from ReadingDetail

-- Insert dữ liệu vào bảng Themes (Chủ đề)
INSERT INTO Themes (ThemeName) 
VALUES 
    (N'Tình yêu'), 
    (N'Sự nghiệp'), 
    (N'Sức khỏe');
GO
SELECT * FROM dbo.ReadingDetails;

-- Insert dữ liệu vào bảng Cards (Lá bài Major Arcana)
INSERT INTO Cards (CardName, UprightMeaning, ReversedMeaning)
VALUES
    ('The Fool', N'Khởi đầu mới, tự do, phiêu lưu', N'Lừa dối, sự ngây thơ, rủi ro'),
    ('The Magician', N'Tài năng, quyền lực, sáng tạo', N'Lạm dụng quyền lực, thất bại'),
    ('The High Priestess', N'Trí tuệ sâu sắc, bí ẩn, sự nhạy cảm', N'Bí mật, thiếu hiểu biết, sự mơ hồ'),
    ('The Empress', N'Sự nuôi dưỡng, sáng tạo, tình yêu', N'Sự thiếu cân bằng, xung đột trong gia đình'),
    ('The Emperor', N'Sự kiểm soát, quyền lực, ổn định', N'Lạm dụng quyền lực, thiếu tôn trọng người khác'),
    ('The Hierophant', N'Truyền thống, sự hướng dẫn, tôn giáo', N'Sự cứng nhắc, không linh hoạt'),
    ('The Lovers', N'Tình yêu, sự kết nối, sự hòa hợp', N'Mối quan hệ tồi tệ, sự lừa dối'),
    ('The Chariot', N'Chiến thắng, sự quyết tâm, kiểm soát', N'Thiếu kỷ luật, thất bại trong kiểm soát'),
    ('Strength', N'Sức mạnh nội tâm, lòng kiên nhẫn, sự kiên trì', N'Sự yếu đuối, thiếu tự tin'),
    ('The Hermit', N'Sự tìm kiếm nội tâm, cô đơn, chiêm nghiệm', N'Cô độc, thiếu định hướng'),
    ('Wheel of Fortune', N'Thay đổi, vận may, thời cơ', N'Đứng im, không thay đổi, thất bại'),
    ('Justice', N'Công lý, sự công bằng, cân bằng', N'Bất công, sự thiếu công bằng'),
    ('The Hanged Man', N'Sự hy sinh, thay đổi quan điểm, buông bỏ', N'Bế tắc, thiếu sự thay đổi'),
    ('Death', N'Chuyển biến lớn, kết thúc và khởi đầu mới', N'Kết thúc không hoàn hảo, sự trì hoãn'),
    ('Temperance', N'Sự cân bằng, điều độ, hòa hợp', N'Thiếu kiểm soát, rối loạn'),
    ('The Devil', N'Cám dỗ, sự phụ thuộc, vật chất', N'Giải thoát, thoát khỏi sự phụ thuộc'),
    ('The Tower', N'Biến động, sự thay đổi bất ngờ, sự sụp đổ', N'Sự chống đối, không chịu thay đổi'),
    ('The Star', N'Hy vọng, niềm tin, sự bình an', N'Mất niềm tin, tuyệt vọng'),
    ('The Moon', N'Ảo giác, bí mật, sự mơ hồ', N'Giải quyết vấn đề, sự tỉnh thức'),
    ('The Sun', N'Hạnh phúc, thành công, ánh sáng', N'Mất đi niềm vui, thất bại'),
    ('Judgement', N'Phán xét, sự hồi sinh, sự thức tỉnh', N'Sự thiếu trách nhiệm, trì trệ'),
    ('The World', N'Hoàn thành, sự thành tựu, sự kết thúc', N'Thiếu hoàn thành, không đủ quyết tâm');
GO
UPDATE Cards
SET ImagePath = 'D:\Study\Lap Trinh Windows\Đồ án cuối kỳ\TarorCard\The World'
WHERE CardID = 22;

select * from Cards
-------------------------------------------------------------------------------Insert vào bảng Meanings---------------------------------------------------------------------------------

-- The Fool
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (1, 1, N'Tình yêu mới mẻ, đầy hy vọng và sự khám phá. Bạn có thể đang bắt đầu một mối quan hệ mới với sự ngây thơ và sự cởi mở.', 
    N'Tình yêu thiếu sự cam kết, bạn có thể đang tránh né sự gắn bó hoặc gặp khó khăn trong việc cam kết với đối phương'),
    (1, 2, N'Bắt đầu một công việc mới hoặc dự án mới đầy triển vọng, nhưng có thể thiếu sự chuẩn bị hoặc kinh nghiệm.', 
    N'Thiếu sự chuẩn bị trong công việc, có thể gặp khó khăn trong việc đưa ra quyết định quan trọng trong sự nghiệp'),
    (1, 3, N'Khám phá sức khỏe theo cách mới, có thể là một chế độ ăn uống hay thói quen luyện tập mới.', 
    N'Thiếu sự quan tâm đúng mức đến sức khỏe, có thể gặp phải các vấn đề do thiếu thận trọng trong lối sống');

-- The Magician
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (2, 1, N'Khả năng kiểm soát tình yêu, bạn có thể sử dụng sức mạnh nội tại để xây dựng mối quan hệ vững chắc và thành công.', 
    N'Lừa dối hoặc thiếu tự tin trong mối quan hệ, có thể có những chiêu trò hoặc sự thao túng trong tình cảm'),
    (2, 2, N'Thành công trong công việc nhờ vào tài năng và sự sáng tạo. Bạn có thể dễ dàng đạt được mục tiêu nghề nghiệp của mình.', 
    N'Thiếu kỹ năng hoặc sáng tạo trong công việc, bạn có thể cảm thấy bị mắc kẹt và không thể phát huy hết khả năng'),
    (2, 3, N'Khả năng sử dụng sức mạnh tinh thần và thể chất để cải thiện sức khỏe.', 
    N'Có thể thiếu động lực để duy trì một lối sống lành mạnh, cần tìm lại sự hứng thú trong việc chăm sóc sức khỏe');

-- The High Priestess
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (3, 1, N'Tình yêu sâu sắc và bí ẩn, bạn có thể không hiểu hết cảm xúc của đối phương hoặc họ cũng có những bí mật cần khám phá.', 
    N'Thiếu sự rõ ràng và giao tiếp trong mối quan hệ, có thể có sự thiếu trung thực hoặc thiếu sự kết nối cảm xúc'),
    (3, 2, N'Sự thấu hiểu và trực giác trong công việc. Bạn có thể khám phá ra những cơ hội mới nhờ vào khả năng cảm nhận và hiểu biết sâu sắc.', 
    N'Cảm thấy thiếu sự thấu hiểu và trực giác trong công việc, có thể bỏ lỡ những cơ hội hoặc cảm thấy không an toàn'),
    (3, 3, N'Sức khỏe được cải thiện qua việc lắng nghe cơ thể và những dấu hiệu tinh thần. Bạn có thể cảm nhận được sự bình yên trong tâm hồn và cơ thể.', 
    N'Cảm giác mệt mỏi và căng thẳng do không chú ý đến nhu cầu của cơ thể, có thể thiếu sự chăm sóc về tinh thần và thể chất');

-- The Empress
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (4, 1, N'Tình yêu đầy sự chăm sóc, nuôi dưỡng và thấu hiểu. Bạn có thể đang chăm sóc và nuôi dưỡng mối quan hệ một cách rất tận tâm.', 
    N'Cảm giác bị bỏ bê hoặc thiếu sự chăm sóc trong tình yêu, có thể có sự ngừng lại trong mối quan hệ hoặc thiếu sự thấu hiểu'),
    (4, 2, N'Sự phát triển và thịnh vượng trong công việc. Đây là thời điểm tốt để tạo dựng sự nghiệp và đạt được thành công lớn.', 
    N'Cảm thấy thiếu sự thịnh vượng trong công việc, có thể gặp phải sự trì trệ hoặc thiếu động lực trong nghề nghiệp'),
    (4, 3, N'Sức khỏe thịnh vượng, bạn có thể cảm thấy sức sống và thể chất tràn đầy. Đây là thời điểm để chăm sóc cơ thể và duy trì sức khỏe.', 
    N'Sức khỏe bị suy yếu, có thể do căng thẳng hoặc thiếu sự chăm sóc đúng mức cho cơ thể');

-- The Emperor
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (5, 1, N'Tình yêu được xây dựng trên nền tảng ổn định và kiên cố, nhưng có thể thiếu sự lãng mạn và sự tự do trong mối quan hệ.', 
    N'Cảm giác bị kiểm soát trong tình yêu, bạn có thể cảm thấy mối quan hệ thiếu sự tự do hoặc bị áp lực từ đối phương'),
    (5, 2, N'Lãnh đạo và quyền lực trong công việc, bạn có thể đang ở vị trí quan trọng trong nghề nghiệp của mình và có thể đưa ra các quyết định lớn.', 
    N'Cảm thấy thiếu quyền lực hoặc không thể kiểm soát công việc, bạn có thể đang bị áp lực trong sự nghiệp hoặc không nhận được sự tôn trọng xứng đáng'),
    (5, 3, N'Cải thiện sức khỏe thông qua việc duy trì kỷ luật và các thói quen tốt. Bạn có thể cảm thấy tự hào với cơ thể và sức khỏe của mình.', 
    N'Cảm thấy thiếu động lực hoặc không thể duy trì một lối sống lành mạnh, có thể gặp vấn đề về sức khỏe do thiếu sự chăm sóc đúng mức');

-- The Hierophant
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (6, 1, N'Tình yêu theo truyền thống và cam kết. Bạn có thể đang tìm kiếm một mối quan hệ ổn định và lâu dài dựa trên giá trị chung.', 
    N'Mối quan hệ thiếu sự linh hoạt hoặc có sự bế tắc do sự bảo thủ hoặc thiếu sự đổi mới trong tình yêu'),
    (6, 2, N'Sự ổn định và bền vững trong công việc, bạn có thể đang tìm kiếm một công việc có tính ổn định và an toàn.', 
    N'Cảm giác bị bó buộc trong công việc hoặc thiếu sự sáng tạo, có thể cảm thấy không phát triển trong nghề nghiệp'),
    (6, 3, N'Sức khỏe ổn định nhờ vào các thói quen lành mạnh và tuân thủ các nguyên tắc chăm sóc cơ thể.', 
    N'Sức khỏe thiếu ổn định do thiếu sự chăm sóc đúng mức hoặc thiếu sự linh hoạt trong thói quen chăm sóc sức khỏe');

-- The Lovers
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (7, 1, N'Mối quan hệ tình yêu đối diện với sự lựa chọn quan trọng. Bạn cần phải đưa ra quyết định về sự cam kết và hướng đi trong tình yêu.', 
    N'Cảm giác thiếu sự hòa hợp trong tình yêu, bạn có thể đang đối mặt với sự không tương thích hoặc thiếu sự kết nối với đối phương'),
    (7, 2, N'Sự lựa chọn quan trọng trong sự nghiệp. Bạn sẽ cần phải đưa ra quyết định khó khăn về hướng đi nghề nghiệp của mình.', 
    N'Cảm giác lúng túng và khó quyết định trong công việc, có thể gặp phải sự mâu thuẫn giữa các lựa chọn nghề nghiệp'),
    (7, 3, N'Sức khỏe được cải thiện nhờ vào sự cân bằng và lựa chọn đúng đắn về chế độ ăn uống và thói quen tập luyện.', 
    N'Sức khỏe không ổn định, có thể do thiếu sự cân bằng trong chế độ ăn uống và các thói quen sinh hoạt');

-- The Chariot
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (8, 1, N'Tình yêu chiến thắng mọi thử thách, bạn có thể đang vượt qua khó khăn và tiến về phía trước trong mối quan hệ.', 
    N'Mối quan hệ bị kìm hãm do thiếu sự quyết tâm hoặc đối mặt với thử thách quá lớn, bạn cần phải tìm lại động lực để duy trì tình yêu'),
    (8, 2, N'Thành công trong công việc nhờ vào sự quyết đoán và kiên trì. Bạn sẽ vượt qua mọi khó khăn trong sự nghiệp.', 
    N'Cảm giác thiếu quyết đoán và thiếu sự kiểm soát trong công việc, bạn có thể gặp khó khăn khi đối mặt với thử thách trong nghề nghiệp'),
    (8, 3, N'Cải thiện sức khỏe nhờ vào sự kiên trì và tập trung vào mục tiêu. Bạn sẽ đạt được kết quả tích cực từ những nỗ lực chăm sóc cơ thể.', 
    N'Sức khỏe bị trì trệ do thiếu quyết tâm hoặc không duy trì được lối sống lành mạnh');

-- The Strength
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (9, 1, N'Tình yêu mạnh mẽ và kiên cường, bạn có thể vượt qua khó khăn và thử thách trong mối quan hệ nhờ vào sự kiên nhẫn và hiểu biết.', 
    N'Mối quan hệ thiếu sự kiên nhẫn hoặc bị thử thách quá mức, bạn cần phải tìm lại sức mạnh và sự đồng cảm để duy trì tình yêu'),
    (9, 2, N'Thành công trong sự nghiệp nhờ vào sự mạnh mẽ và kiên trì. Bạn có thể đạt được mục tiêu nghề nghiệp dù gặp khó khăn.', 
    N'Cảm giác yếu đuối hoặc thiếu năng lượng trong công việc, bạn có thể cảm thấy thiếu tự tin và dễ bị bỏ cuộc trong sự nghiệp'),
    (9, 3, N'Sức khỏe được củng cố nhờ vào sự kiên trì trong việc luyện tập và chăm sóc bản thân.', 
    N'Sức khỏe suy yếu do thiếu sự kiên trì hoặc thiếu động lực để chăm sóc cơ thể');

-- The Hermit
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (10, 1, N'Tình yêu tìm về sự tĩnh lặng và tự suy ngẫm. Bạn có thể đang tìm kiếm sự bình yên và không muốn tham gia vào những mối quan hệ phức tạp.', 
    N'Cảm giác cô đơn trong tình yêu, có thể bạn đang tránh né mối quan hệ hoặc không muốn đối mặt với tình cảm của mình'),
    (10, 2, N'Cảm giác cần phải tìm kiếm sự thật và hiểu biết trong công việc. Bạn có thể cần thời gian riêng để suy nghĩ về nghề nghiệp của mình.', 
    N'Cảm thấy bị cô lập hoặc thiếu sự hướng dẫn trong công việc, bạn có thể cảm thấy không thể tiến lên hoặc thiếu sự kết nối trong nghề nghiệp'),
    (10, 3, 'Sức khỏe yêu cầu sự tĩnh lặng và thời gian để phục hồi. Bạn có thể cần thời gian để chiêm nghiệm và cải thiện tình trạng thể chất của mình.', 
    N'Cảm thấy mất phương hướng trong việc chăm sóc sức khỏe, có thể bạn đang cảm thấy mệt mỏi và thiếu động lực để cải thiện cơ thể');

-- The Wheel of Fortune
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (11, 1, N'Mối quan hệ thay đổi theo sự sắp đặt của số phận. Bạn có thể cảm thấy như mình không thể kiểm soát tình yêu, nhưng mọi thứ đang diễn ra theo cách đúng đắn.', 
    N'Cảm giác không thể kiểm soát tình yêu, bạn có thể gặp phải sự thay đổi bất ngờ hoặc không thể làm chủ được tình huống trong mối quan hệ'),
    (11, 2, N'Công việc thay đổi theo sự may mắn hoặc định mệnh. Bạn có thể nhận được cơ hội lớn từ những tình huống bất ngờ trong nghề nghiệp.', 
    N'Cảm giác không thể kiểm soát sự nghiệp, có thể gặp phải sự thay đổi xấu hoặc khó khăn trong công việc'),
    (11, 3, N'Sức khỏe có thể được cải thiện nhờ may mắn hoặc sự thay đổi tích cực. Đây là thời gian tốt để tập trung vào việc phục hồi hoặc cải thiện thể chất.', 
    N'Có thể gặp phải sự suy giảm bất ngờ về sức khỏe hoặc cảm thấy thiếu kiểm soát với các vấn đề thể chất.');


-- The Justice
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (12, 1, N'Tình yêu được xây dựng trên nền tảng công bằng và sự thấu hiểu, bạn sẽ đạt được sự cân bằng trong mối quan hệ.', 
    N'Mối quan hệ thiếu công bằng hoặc bạn có thể gặp phải sự xung đột do thiếu sự thấu hiểu và giao tiếp trong tình yêu'),
    (12, 2, N'Sự công bằng trong công việc. Bạn sẽ nhận được sự công nhận và đền đáp xứng đáng cho những nỗ lực trong sự nghiệp.', 
    N'Thiếu sự công bằng trong công việc, bạn có thể cảm thấy bị bỏ qua hoặc không được đối xử công bằng'),
    (12, 3, N'Cảm giác cân bằng trong sức khỏe, bạn có thể duy trì một chế độ ăn uống và tập luyện hợp lý để duy trì sự cân bằng trong cơ thể.', 
    N'Sức khỏe mất cân bằng, bạn có thể gặp phải các vấn đề do chế độ ăn uống không hợp lý hoặc thiếu sự cân bằng trong cuộc sống');

-- The Hanged Man
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (13, 1, N'Tình yêu đối mặt với sự hy sinh và chờ đợi. Bạn có thể đang phải đối diện với sự tạm dừng hoặc trì hoãn trong mối quan hệ.', 
    N'Cảm giác thiếu sự hy sinh hoặc bạn có thể đang trốn tránh trách nhiệm trong tình yêu'),
    (13, 2, N'Công việc cần sự thay đổi góc nhìn và sự linh hoạt. Bạn có thể cần phải tạm dừng và suy nghĩ lại về hướng đi trong sự nghiệp.', 
    N'Cảm giác thiếu sự linh hoạt trong công việc, bạn có thể cảm thấy bế tắc và không thể tiến về phía trước trong sự nghiệp'),
    (13, 3, N'Sức khỏe cần được chăm sóc từ từ và một cách kiên nhẫn. Bạn có thể cần thời gian để phục hồi và cải thiện tình trạng cơ thể của mình.', 
    N'Sức khỏe bị trì hoãn hoặc gặp khó khăn trong việc phục hồi, bạn cần sự kiên nhẫn và cách tiếp cận hợp lý để cải thiện cơ thể');

-- The Death
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (14, 1, N'Tình yêu có thể phải kết thúc hoặc thay đổi mạnh mẽ. Bạn có thể đang đối diện với sự kết thúc của một chương trong mối quan hệ hoặc một sự chuyển mình lớn.', 
    N'Mối quan hệ thiếu sự thay đổi hoặc bạn có thể gặp phải sự trì hoãn trong việc thay đổi để tạo ra một mối quan hệ tốt hơn'),
    (14, 2, N'Sự kết thúc trong công việc hoặc một sự thay đổi lớn. Bạn có thể phải đối diện với sự kết thúc của một dự án hoặc sự nghiệp.', 
    N'Cảm giác thiếu thay đổi hoặc không thể tiến về phía trước trong sự nghiệp, bạn có thể cảm thấy bị mắc kẹt trong công việc'),
    (14, 3, N'Sức khỏe cần sự thay đổi và cải thiện lớn. Bạn có thể cần phải thay đổi thói quen để cải thiện tình trạng sức khỏe của mình.', 
    N'Sức khỏe không tiến triển hoặc gặp phải sự trì trệ, bạn cần phải tìm cách thay đổi lối sống để có thể cải thiện cơ thể');

-- The Temperance
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (15, 1, N'Tình yêu được xây dựng trên sự hòa hợp và thỏa hiệp. Bạn có thể tìm thấy sự cân bằng trong mối quan hệ và cùng nhau phát triển.', 
    N'Mối quan hệ thiếu sự hòa hợp, có thể có sự xung đột hoặc thiếu sự kiên nhẫn và thỏa hiệp trong tình cảm'),
    (15, 2,N'Công việc đòi hỏi sự kiên nhẫn và sự cân bằng giữa các yếu tố khác nhau. Bạn có thể đang cố gắng điều chỉnh công việc và cuộc sống.', 
    N'Cảm giác mất cân bằng trong công việc, có thể cảm thấy căng thẳng hoặc không thể hoàn thành công việc một cách hiệu quả'),
    (15, 3, N'Sức khỏe được duy trì thông qua sự cân bằng và điều độ. Bạn có thể cảm thấy khỏe mạnh khi duy trì một chế độ ăn uống và luyện tập hợp lý.', 
    N'Sức khỏe thiếu cân bằng, bạn có thể cảm thấy mệt mỏi hoặc mất sức do thiếu sự điều độ trong lối sống');

-- The Devil
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (16, 1, N'Tình yêu có thể bị cản trở bởi sự kiểm soát, nghi ngờ hoặc sự lệ thuộc vào đối phương. Bạn có thể đang cảm thấy bị kìm kẹp trong mối quan hệ.', 
    N'Mối quan hệ đang bị gỡ bỏ các yếu tố tiêu cực, bạn có thể bắt đầu thoát khỏi sự kiểm soát và tìm lại sự tự do trong tình yêu'),
    (16, 2, N'Công việc có thể bị chi phối bởi tham vọng thái quá hoặc cảm giác lệ thuộc vào quyền lực. Bạn cần phải thoát khỏi sự phụ thuộc vào một yếu tố nào đó trong nghề nghiệp.', 
    N'Thành công trong công việc nhờ vào việc thoát khỏi sự lệ thuộc hoặc thoát khỏi những yếu tố tiêu cực trong sự nghiệp'),
    (16, 3, N'Sức khỏe có thể bị ảnh hưởng bởi thói quen xấu hoặc nghiện ngập. Bạn cần phải nhận ra và loại bỏ những yếu tố gây hại cho cơ thể.', 
    N'Sức khỏe dần hồi phục khi bạn loại bỏ các thói quen xấu và tìm cách sống lành mạnh hơn');

-- The Tower
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (17, 1, N'Tình yêu có thể gặp phải sự thay đổi đột ngột hoặc khủng hoảng. Mối quan hệ có thể bị phá vỡ hoặc có một sự biến đổi mạnh mẽ.', 
    N'Mối quan hệ tránh được khủng hoảng hoặc bạn có thể đã vượt qua một thử thách lớn và xây dựng lại sự kết nối cảm xúc'),
    (17, 2, N'Sự thay đổi đột ngột trong công việc có thể khiến bạn cảm thấy bất ngờ hoặc không sẵn sàng. Tuy nhiên, đây là cơ hội để tái thiết và phát triển.', 
    N'Cảm thấy không thể thay đổi hoặc không thể thích nghi trong công việc, bạn có thể cảm thấy bị mất phương hướng hoặc thiếu sự ổn định'),
    (17, 3, N'Sức khỏe có thể gặp sự đổ vỡ do các yếu tố bất ngờ hoặc thay đổi lớn. Bạn có thể phải đối diện với các vấn đề bất ngờ trong sức khỏe.', 
    N'Sức khỏe phục hồi sau sự thay đổi hoặc thay đổi lối sống, bạn có thể nhận ra các yếu tố cần thiết để cải thiện sức khỏe');

-- The Star
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (18, 1, N'Tình yêu đầy hy vọng và sự lạc quan. Bạn có thể đang tìm thấy sự sáng suốt và sự kết nối sâu sắc trong mối quan hệ.', 
    N'Mối quan hệ thiếu sự hy vọng hoặc bị thiếu sự kết nối, có thể cảm thấy thất vọng hoặc mất niềm tin vào tình yêu'),
    (18, 2, N'Sự đổi mới và sáng tạo trong công việc. Bạn có thể đang nhận được những cơ hội tuyệt vời hoặc sự khởi đầu mới trong nghề nghiệp.', 
    N'Cảm thấy thiếu hy vọng trong công việc, có thể gặp phải sự thất vọng hoặc cảm giác bị mất phương hướng trong sự nghiệp'),
    (18, 3, N'Sức khỏe được cải thiện nhờ vào hy vọng và niềm tin vào bản thân. Bạn có thể cảm thấy tràn đầy năng lượng và tự tin vào quá trình phục hồi.', 
    N'Sức khỏe không ổn định, có thể cảm thấy thiếu động lực hoặc cảm giác mệt mỏi kéo dài');

-- The Moon
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (19, 1, N'Tình yêu bị che khuất bởi sự mơ hồ, bạn có thể không rõ ràng về cảm xúc của đối phương hoặc cảm thấy không an tâm trong mối quan hệ.', 
    N'Mối quan hệ trở nên rõ ràng hơn, bạn có thể gỡ bỏ các sự nghi ngờ và tìm lại sự tin tưởng và sự kết nối trong tình yêu'),
    (19, 2, N'Công việc thiếu sự rõ ràng, bạn có thể gặp phải sự mơ hồ hoặc những khó khăn không xác định trong nghề nghiệp.', 
    N'Cảm thấy rõ ràng hơn trong công việc, bạn có thể thoát khỏi sự mơ hồ và nhận thức đúng đắn về nghề nghiệp của mình'),
    (19, 3, N'Sức khỏe bị ảnh hưởng bởi sự mơ hồ trong việc chăm sóc bản thân, bạn có thể đang thiếu sự rõ ràng trong lối sống hoặc chế độ ăn uống.', 
    N'Sức khỏe dần phục hồi khi bạn có cái nhìn rõ ràng hơn về những gì cơ thể cần và cải thiện thói quen sinh hoạt');

-- The Sun
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (20, 1, N'Tình yêu được chiếu sáng bằng sự chân thành và niềm vui. Bạn có thể cảm thấy hạnh phúc và tự do trong mối quan hệ.', 
    N'Mối quan hệ thiếu sự tươi sáng hoặc có sự u ám, bạn có thể cảm thấy bất an hoặc thiếu sự lạc quan trong tình yêu'),
    (20, 2, N'Công việc đạt được thành công và sự công nhận. Bạn có thể cảm thấy tự hào về những gì mình đã đạt được và nhận được sự khen thưởng xứng đáng.', 
    N'Cảm thấy thiếu động lực trong công việc, có thể gặp phải sự thất vọng hoặc cảm thấy không được công nhận trong nghề nghiệp'),
    (20, 3, N'Sức khỏe được cải thiện nhờ vào sự tự chăm sóc và niềm vui trong cuộc sống. Bạn có thể cảm thấy sức sống tràn đầy và khỏe mạnh.', 
    N'Sức khỏe bị suy giảm do thiếu sự lạc quan hoặc sự chăm sóc bản thân, có thể cảm thấy thiếu năng lượng hoặc mệt mỏi');

-- The Judgment
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (21, 1, N'Tình yêu đối diện với sự tái sinh và nhận thức mới. Bạn có thể đang đối diện với sự thức tỉnh trong mối quan hệ và khám phá lại cảm xúc của mình.', 
    N'Mối quan hệ bị đình trệ hoặc bạn không thể vượt qua những sai lầm trong quá khứ, cần phải thay đổi để phát triển tình yêu'),
    (21, 2, N'Công việc đối mặt với sự thức tỉnh và quyết định quan trọng. Bạn có thể sẽ đưa ra quyết định lớn trong nghề nghiệp hoặc có sự thay đổi quan trọng.', 
    N'Cảm giác bị mắc kẹt trong công việc, có thể bạn không thể đưa ra quyết định quan trọng hoặc không sẵn sàng thay đổi trong sự nghiệp'),
    (21, 3, N'Sức khỏe cần sự tái sinh và phục hồi. Bạn có thể cảm thấy mình đang bước vào giai đoạn mới của cuộc sống với sức khỏe hồi phục.', 
    N'Sức khỏe bị trì trệ hoặc thiếu sự phục hồi, bạn có thể gặp phải vấn đề sức khỏe lâu dài nếu không thay đổi thói quen chăm sóc cơ thể');

-- The World
INSERT INTO Meanings (CardID, ThemeID, UprightMeaning, ReversedMeaning)
VALUES 
    (22, 1, N'Tình yêu viên mãn và hoàn hảo. Bạn có thể cảm thấy mình đã tìm được đối tác lý tưởng và đạt được sự hòa hợp trong mối quan hệ.', 
    N'Mối quan hệ thiếu sự kết nối hoặc cảm giác chưa hoàn thành, bạn có thể cảm thấy không thể tiến đến một giai đoạn cao hơn trong tình yêu'),
    (22, 2, N'Công việc hoàn thành và đạt được mục tiêu. Bạn có thể cảm thấy hài lòng với những gì đã đạt được và sẵn sàng cho thử thách tiếp theo.', 
    N'Cảm thấy chưa hoàn thành trong công việc, bạn có thể gặp phải sự trì trệ hoặc không thể đạt được các mục tiêu nghề nghiệp như mong đợi'),
    (22, 3, N'Sức khỏe hoàn hảo, bạn có thể cảm thấy đầy năng lượng và tự hào với cơ thể của mình. Bạn đang ở giai đoạn tốt nhất về sức khỏe.', 
    N'Sức khỏe không hoàn hảo, bạn có thể cảm thấy thiếu sức sống hoặc gặp phải một số vấn đề sức khỏe cần phải giải quyết');

	select * from Cards