using System.Text;
using FarmSystem;
using FarmSystem.Models;
using FluentAssertions;
using Xunit;

namespace FarmSystemTests
{
    public class FarmFacts
    {
        [Fact]
        public void Animals_WhenCreated_ShouldHaveUniqueId()
        {
            // Arrange
            var cow1 = Market.Purchase(typeof(Cow));
            var cow2 = Market.Purchase(typeof(Cow));

            // Act
            // - nothing to act on

            // Assert
            cow1.Id.Should().NotBeNullOrEmpty();
            cow2.Id.Should().NotBeNullOrEmpty();
            cow1.Id.Should().NotBeEquivalentTo(cow2.Id);
        }

        [Fact]
        public void Farms_WithNoCows_CantMilk()
        {
            // Arrange
            var expected = "Hen has entered the farm\r\nHorse has entered the farm\r\nSheep has entered the farm\r\nCannot identify the farm animals which can be milked\r\n";
            var actual = new StringBuilder();
            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.Enter(Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));
            farm.MilkAnimals();

            // Assert
            actual.ToString().Should().Be(expected);
        }

        [Fact]
        public void Farms_WithNoAnimals_WontScare()
        {
            // Arrange
            var expected = "There are no animals on the farm that can talk\r\n";
            var actual = new StringBuilder();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.MakeNoise();

            // Assert
            actual.ToString().Should().Be(expected);
        }

        [Fact]
        public void Test1Output()
        {
            // Arrange
            var expected = "Cow has entered the farm\r\nHen has entered the farm\r\nHorse has entered the farm\r\nSheep has entered the farm\r\n";
            var actual = new StringBuilder();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.Enter(Market.Purchase(typeof(Cow)), Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));

            // Assert
            actual.ToString().Should().Be(expected);
        }

        [Fact]
        public void Test2Output()
        {
            // Arrange
            var expected = "Cow has entered the farm\r\nHen has entered the farm\r\nHorse has entered the farm\r\nSheep has entered the farm\r\nCow says Moo!\r\nHen says CLUCKAAAAAWWWWK!\r\nHorse says Neigh!\r\nSheep says baa!\r\n";
            var actual = new StringBuilder();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.Enter(Market.Purchase(typeof(Cow)), Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));
            farm.MakeNoise();

            // Assert
            actual.ToString().Should().Be(expected);
        }

        [Fact]
        public void Test3Output()
        {
            // Arrange
            var expected = "Cow has entered the farm\r\nHen has entered the farm\r\nHorse has entered the farm\r\nSheep has entered the farm\r\nCow was milked!\r\n";
            var actual = new StringBuilder();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.Enter(Market.Purchase(typeof(Cow)), Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));
            farm.MilkAnimals();

            // Assert
            actual.ToString().Should().Be(expected);
        }

        [Fact]
        public void Test4Output()
        {
            // Arrange
            var expected = "Cow has entered the farm\r\nHen has entered the farm\r\nHorse has entered the farm\r\nSheep has entered the farm\r\nCow has left the farm\r\nHen has left the farm\r\nHorse has left the farm\r\nSheep has left the farm\r\nEmydex Farm is now empty\r\n";
            var actual = new StringBuilder();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => actual.AppendLine(e.Message);

            // Act
            farm.Enter(Market.Purchase(typeof(Cow)), Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));
            farm.ReleaseAllAnimals();

            // Assert
            actual.ToString().Should().Be(expected);
        }
    }
}
