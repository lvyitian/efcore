// <auto-generated />

using System.Reflection;
using System.Resources;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class RelationalStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Properties.RelationalStrings", typeof(RelationalStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     Cannot create a ModificationFunction for an entity in state '{entityState}'.
        /// </summary>
        public static string ModificationFunctionInvalidEntityState([CanBeNull] object entityState)
            => string.Format(
                GetString("ModificationFunctionInvalidEntityState", nameof(entityState)),
                entityState);

        /// <summary>
        ///     Database operation expected to affect {expectedRows} row(s) but actually affected {actualRows} row(s). Data may have been modified or deleted since entities were loaded. See http://go.microsoft.com/fwlink/?LinkId=527962 for information on understanding and handling optimistic concurrency exceptions.
        /// </summary>
        public static string UpdateConcurrencyException([CanBeNull] object expectedRows, [CanBeNull] object actualRows)
            => string.Format(
                GetString("UpdateConcurrencyException", nameof(expectedRows), nameof(actualRows)),
                expectedRows, actualRows);

        /// <summary>
        ///     Multiple relational database provider configurations found. A context can only be configured to use a single database provider.
        /// </summary>
        public static string MultipleProvidersConfigured
            => GetString("MultipleProvidersConfigured");

        /// <summary>
        ///     No relational database providers are configured. Configure a database provider using OnConfiguring or by creating an ImmutableDbContextOptions with a database provider configured and passing it to the context.
        /// </summary>
        public static string NoProviderConfigured
            => GetString("NoProviderConfigured");

        /// <summary>
        ///     Both an existing DbConnection and a connection string have been configured. When an existing DbConnection is used the connection string must be set on that connection.
        /// </summary>
        public static string ConnectionAndConnectionString
            => GetString("ConnectionAndConnectionString");

        /// <summary>
        ///     A relational store has been configured without specifying either the DbConnection or connection string to use.
        /// </summary>
        public static string NoConnectionOrConnectionString
            => GetString("NoConnectionOrConnectionString");

        /// <summary>
        ///     No mapping to a relational type can be found for the CLR type '{clrType}'.
        /// </summary>
        public static string UnsupportedType([CanBeNull] object clrType)
            => string.Format(
                GetString("UnsupportedType", nameof(clrType)),
                clrType);

        /// <summary>
        ///     Relational-specific methods can only be used when the context is using a relational database provider.
        /// </summary>
        public static string RelationalNotInUse
            => GetString("RelationalNotInUse");

        /// <summary>
        ///     An error occurred while updating the entries. See the inner exception for details.
        /// </summary>
        public static string UpdateStoreException
            => GetString("UpdateStoreException");

        /// <summary>
        ///     The connection is already in a transaction and cannot participate in another transaction.
        /// </summary>
        public static string TransactionAlreadyStarted
            => GetString("TransactionAlreadyStarted");

        /// <summary>
        ///     The specified transaction is not associated with the current connection. Only transactions associated with the current connection may be used.
        /// </summary>
        public static string TransactionAssociatedWithDifferentConnection
            => GetString("TransactionAssociatedWithDifferentConnection");

        /// <summary>
        ///     Opening connection to database '{database}' on server '{server}'.
        /// </summary>
        public static string RelationalLoggerOpeningConnection([CanBeNull] object database, [CanBeNull] object server)
            => string.Format(
                GetString("RelationalLoggerOpeningConnection", nameof(database), nameof(server)),
                database, server);

        /// <summary>
        ///     Closing connection to database '{database}' on server '{server}'.
        /// </summary>
        public static string RelationalLoggerClosingConnection([CanBeNull] object database, [CanBeNull] object server)
            => string.Format(
                GetString("RelationalLoggerClosingConnection", nameof(database), nameof(server)),
                database, server);

        /// <summary>
        ///     Beginning transaction with isolation level '{isolationLevel}'.
        /// </summary>
        public static string RelationalLoggerBeginningTransaction([CanBeNull] object isolationLevel)
            => string.Format(
                GetString("RelationalLoggerBeginningTransaction", nameof(isolationLevel)),
                isolationLevel);

        /// <summary>
        ///     Committing transaction.
        /// </summary>
        public static string RelationalLoggerCommittingTransaction
            => GetString("RelationalLoggerCommittingTransaction");

        /// <summary>
        ///     Rolling back transaction.
        /// </summary>
        public static string RelationalLoggerRollingbackTransaction
            => GetString("RelationalLoggerRollingbackTransaction");

        /// <summary>
        ///     Invalid type for sequence. Valid types are 'Int64' (the default), 'Int32', 'Int16', and 'Byte'.
        /// </summary>
        public static string BadSequenceType
            => GetString("BadSequenceType");

        /// <summary>
        ///     Unable to deserialize sequence from model metadata. See inner exception for details.
        /// </summary>
        public static string BadSequenceString
            => GetString("BadSequenceString");

        /// <summary>
        ///     The migration '{migrationName}' was not found.
        /// </summary>
        public static string MigrationNotFound([CanBeNull] object migrationName)
            => string.Format(
                GetString("MigrationNotFound", nameof(migrationName)),
                migrationName);

        /// <summary>
        ///     The current migration SQL generator '{sqlGeneratorType}' is unable to generate SQL for operations of type '{operationType}'.
        /// </summary>
        public static string UnknownOperation([CanBeNull] object sqlGeneratorType, [CanBeNull] object operationType)
            => string.Format(
                GetString("UnknownOperation", nameof(sqlGeneratorType), nameof(operationType)),
                sqlGeneratorType, operationType);

        /// <summary>
        ///     The specified CommandTimeout value is not valid. It must be a positive number.
        /// </summary>
        public static string InvalidCommandTimeout
            => GetString("InvalidCommandTimeout");

        /// <summary>
        ///     The specified MaxBatchSize value is not valid. It must be a positive number.
        /// </summary>
        public static string InvalidMaxBatchSize
            => GetString("InvalidMaxBatchSize");

        /// <summary>
        ///     Unable to materialize entity of type '{entityType}'. No discriminators were matched.
        /// </summary>
        public static string UnableToDiscriminate([CanBeNull] object entityType)
            => string.Format(
                GetString("UnableToDiscriminate", nameof(entityType)),
                entityType);

        /// <summary>
        ///     A discriminator property cannot be set for the entity type '{entityType}' because it is not the root of an inheritance hierarchy.
        /// </summary>
        public static string DiscriminatorPropertyMustBeOnRoot([CanBeNull] object entityType)
            => string.Format(
                GetString("DiscriminatorPropertyMustBeOnRoot", nameof(entityType)),
                entityType);

        /// <summary>
        ///     Unable to set property '{property}' as a discriminator for entity type '{entityType}' because it is not a property of '{entityType}'.
        /// </summary>
        public static string DiscriminatorPropertyNotFound([CanBeNull] object property, [CanBeNull] object entityType)
            => string.Format(
                GetString("DiscriminatorPropertyNotFound", nameof(property), nameof(entityType)),
                property, entityType);

        /// <summary>
        ///     An ambient transaction has been detected. Entity Framework Core does not support ambient transactions. See http://go.microsoft.com/fwlink/?LinkId=800142
        /// </summary>
        public static string AmbientTransaction
            => GetString("AmbientTransaction");

        /// <summary>
        ///     Possible unintended use of method Equals(object) for arguments of different types: '{left}', '{right}'. This comparison will always return 'false'.
        /// </summary>
        public static string PossibleUnintendedUseOfEquals([CanBeNull] object left, [CanBeNull] object right)
            => string.Format(
                GetString("PossibleUnintendedUseOfEquals", nameof(left), nameof(right)),
                left, right);

        /// <summary>
        ///     Linq translation for method '{function}' used by this database provider can return incorrect results when the value argument contains wildcard characters (e.g. '%' or '_').
        /// </summary>
        public static string PossibleIncorrectResultsUsingLikeOperator([CanBeNull] object function)
            => string.Format(
                GetString("PossibleIncorrectResultsUsingLikeOperator", nameof(function)),
                function);

        /// <summary>
        ///     The Include operation is not supported when calling a stored procedure.
        /// </summary>
        public static string StoredProcedureIncludeNotSupported
            => GetString("StoredProcedureIncludeNotSupported");

        /// <summary>
        ///     Generating down script for migration '{migration}'.
        /// </summary>
        public static string GeneratingDown([CanBeNull] object migration)
            => string.Format(
                GetString("GeneratingDown", nameof(migration)),
                migration);

        /// <summary>
        ///     Generating up script for migration '{migration}'.
        /// </summary>
        public static string GeneratingUp([CanBeNull] object migration)
            => string.Format(
                GetString("GeneratingUp", nameof(migration)),
                migration);

        /// <summary>
        ///     Applying migration '{migration}'.
        /// </summary>
        public static string ApplyingMigration([CanBeNull] object migration)
            => string.Format(
                GetString("ApplyingMigration", nameof(migration)),
                migration);

        /// <summary>
        ///     Reverting migration '{migration}'.
        /// </summary>
        public static string RevertingMigration([CanBeNull] object migration)
            => string.Format(
                GetString("RevertingMigration", nameof(migration)),
                migration);

        /// <summary>
        ///     Using database '{database}' on server '{dataSource}'.
        /// </summary>
        public static string UsingConnection([CanBeNull] object database, [CanBeNull] object dataSource)
            => string.Format(
                GetString("UsingConnection", nameof(database), nameof(dataSource)),
                database, dataSource);

        /// <summary>
        ///     The required column '{column}' was not present in the results of a 'FromSql' operation.
        /// </summary>
        public static string FromSqlMissingColumn([CanBeNull] object column)
            => string.Format(
                GetString("FromSqlMissingColumn", nameof(column)),
                column);

        /// <summary>
        ///     Cannot use table '{table}' in schema '{schema}' for entity '{entityType}' since it is being used for another entity.
        /// </summary>
        public static string DuplicateTableName([CanBeNull] object table, [CanBeNull] object schema, [CanBeNull] object entityType)
            => string.Format(
                GetString("DuplicateTableName", nameof(table), nameof(schema), nameof(entityType)),
                table, schema, entityType);

        /// <summary>
        ///     Property '{property}' on entity type '{entityType}' is part of a primary or alternate key but has a constant default value set. Constant default values are not useful for primary or alternate keys since these properties must always have non-null unqiue values.
        /// </summary>
        public static string KeyHasDefaultValue([CanBeNull] object property, [CanBeNull] object entityType)
            => string.Format(
                GetString("KeyHasDefaultValue", nameof(property), nameof(entityType)),
                property, entityType);

        /// <summary>
        ///     Cannot configure the discriminator value for entity type '{entityType}' because it doesn't derive from '{rootEntityType}'.
        /// </summary>
        public static string DiscriminatorEntityTypeNotDerived([CanBeNull] object entityType, [CanBeNull] object rootEntityType)
            => string.Format(
                GetString("DiscriminatorEntityTypeNotDerived", nameof(entityType), nameof(rootEntityType)),
                entityType, rootEntityType);

        /// <summary>
        ///     Cannot set discriminator value '{value}' for discriminator property '{discriminator}' because it is not assignable to property of type '{discriminatorType}'.
        /// </summary>
        public static string DiscriminatorValueIncompatible([CanBeNull] object value, [CanBeNull] object discriminator, [CanBeNull] object discriminatorType)
            => string.Format(
                GetString("DiscriminatorValueIncompatible", nameof(value), nameof(discriminator), nameof(discriminatorType)),
                value, discriminator, discriminatorType);

        /// <summary>
        ///     Cannot set discriminator value for entity type '{entityType}' because the root entity type '{rootEntityType}' doesn't have a discriminator property set.
        /// </summary>
        public static string NoDiscriminatorForValue([CanBeNull] object entityType, [CanBeNull] object rootEntityType)
            => string.Format(
                GetString("NoDiscriminatorForValue", nameof(entityType), nameof(rootEntityType)),
                entityType, rootEntityType);

        /// <summary>
        ///     The entity type '{entityType}' is part of a hierarchy, but does not have a discriminator property configured.
        /// </summary>
        public static string NoDiscriminatorProperty([CanBeNull] object entityType)
            => string.Format(
                GetString("NoDiscriminatorProperty", nameof(entityType)),
                entityType);

        /// <summary>
        ///     The entity type '{entityType}' is part of a hierarchy, but does not have a discriminator value configured.
        /// </summary>
        public static string NoDiscriminatorValue([CanBeNull] object entityType)
            => string.Format(
                GetString("NoDiscriminatorValue", nameof(entityType)),
                entityType);

        /// <summary>
        ///     The LINQ expression '{expression}' could not be translated and will be evaluated locally.
        /// </summary>
        public static string ClientEvalWarning([CanBeNull] object expression)
            => string.Format(
                GetString("ClientEvalWarning", nameof(expression)),
                expression);

        /// <summary>
        ///     No value provided for required parameter '{parameter}'.
        /// </summary>
        public static string MissingParameterValue([CanBeNull] object parameter)
            => string.Format(
                GetString("MissingParameterValue", nameof(parameter)),
                parameter);

        /// <summary>
        ///     Cannot use the value provided for parameter '{parameter}' because it isn't assignable to type object[].
        /// </summary>
        public static string ParameterNotObjectArray([CanBeNull] object parameter)
            => string.Format(
                GetString("ParameterNotObjectArray", nameof(parameter)),
                parameter);

        /// <summary>
        ///     Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
        /// </summary>
        public static string RelationalLoggerExecutedCommand([CanBeNull] object elapsed, [CanBeNull] object parameters, [CanBeNull] object commandType, [CanBeNull] object commandTimeout, [CanBeNull] object newLine, [CanBeNull] object commandText)
            => string.Format(
                GetString("RelationalLoggerExecutedCommand", nameof(elapsed), nameof(parameters), nameof(commandType), nameof(commandTimeout), nameof(newLine), nameof(commandText)),
                elapsed, parameters, commandType, commandTimeout, newLine, commandText);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured to use different data types ('{dataType1}' and '{dataType2}').
        /// </summary>
        public static string DuplicateColumnNameDataTypeMismatch([CanBeNull] object entityType1, [CanBeNull] object property1, [CanBeNull] object entityType2, [CanBeNull] object property2, [CanBeNull] object columnName, [CanBeNull] object table, [CanBeNull] object dataType1, [CanBeNull] object dataType2)
            => string.Format(
                GetString("DuplicateColumnNameDataTypeMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table), nameof(dataType1), nameof(dataType2)),
                entityType1, property1, entityType2, property2, columnName, table, dataType1, dataType2);

        /// <summary>
        ///     The connection does not have any active transactions.
        /// </summary>
        public static string NoActiveTransaction
            => GetString("NoActiveTransaction");

        /// <summary>
        ///     Two entities cannot make conflicting updates to the same row.
        /// </summary>
        public static string ConflictingRowUpdates
            => GetString("ConflictingRowUpdates");

        /// <summary>
        ///     Cannot set default value '{value}' of type '{valueType}' on property '{property}' of type '{propertyType}' in entity type '{entityType}'.
        /// </summary>
        public static string IncorrectDefaultValueType([CanBeNull] object value, [CanBeNull] object valueType, [CanBeNull] object property, [CanBeNull] object propertyType, [CanBeNull] object entityType)
            => string.Format(
                GetString("IncorrectDefaultValueType", nameof(value), nameof(valueType), nameof(property), nameof(propertyType), nameof(entityType)),
                value, valueType, property, propertyType, entityType);

        /// <summary>
        ///     The discriminator value for '{entityType1}' is '{discriminatorValue}' which is the same for '{entityType2}'. Every concrete entity type in the hierarchy needs to have a unique discriminator value.
        /// </summary>
        public static string DuplicateDiscriminatorValue([CanBeNull] object entityType1, [CanBeNull] object discriminatorValue, [CanBeNull] object entityType2)
            => string.Format(
                GetString("DuplicateDiscriminatorValue", nameof(entityType1), nameof(discriminatorValue), nameof(entityType2)),
                entityType1, discriminatorValue, entityType2);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured with different nullability.
        /// </summary>
        public static string DuplicateColumnNameNullabilityMismatch([CanBeNull] object entityType1, [CanBeNull] object property1, [CanBeNull] object entityType2, [CanBeNull] object property2, [CanBeNull] object columnName, [CanBeNull] object table)
            => string.Format(
                GetString("DuplicateColumnNameNullabilityMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table)),
                entityType1, property1, entityType2, property2, columnName, table);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured to use different computed values ('{value1}' and '{value2}').
        /// </summary>
        public static string DuplicateColumnNameComputedSqlMismatch([CanBeNull] object entityType1, [CanBeNull] object property1, [CanBeNull] object entityType2, [CanBeNull] object property2, [CanBeNull] object columnName, [CanBeNull] object table, [CanBeNull] object value1, [CanBeNull] object value2)
            => string.Format(
                GetString("DuplicateColumnNameComputedSqlMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table), nameof(value1), nameof(value2)),
                entityType1, property1, entityType2, property2, columnName, table, value1, value2);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured to use different default values ('{value1}' and '{value2}').
        /// </summary>
        public static string DuplicateColumnNameDefaultSqlMismatch([CanBeNull] object entityType1, [CanBeNull] object property1, [CanBeNull] object entityType2, [CanBeNull] object property2, [CanBeNull] object columnName, [CanBeNull] object table, [CanBeNull] object value1, [CanBeNull] object value2)
            => string.Format(
                GetString("DuplicateColumnNameDefaultSqlMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table), nameof(value1), nameof(value2)),
                entityType1, property1, entityType2, property2, columnName, table, value1, value2);

        /// <summary>
        ///     {conflictingConfiguration} cannot be set for '{property}', because {existingConfiguration} is already set.
        /// </summary>
        public static string ConflictingColumnServerGeneration([CanBeNull] object conflictingConfiguration, [CanBeNull] object property, [CanBeNull] object existingConfiguration)
            => string.Format(
                GetString("ConflictingColumnServerGeneration", nameof(conflictingConfiguration), nameof(property), nameof(existingConfiguration)),
                conflictingConfiguration, property, existingConfiguration);

        /// <summary>
        ///     The foreign keys {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{foreignKeyName}' but use different columns ({columnNames1} and {columnNames2}).
        /// </summary>
        public static string DuplicateForeignKeyColumnMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object foreignKeyName, [CanBeNull] object columnNames1, [CanBeNull] object columnNames2)
            => string.Format(
                GetString("DuplicateForeignKeyColumnMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(foreignKeyName), nameof(columnNames1), nameof(columnNames2)),
                index1, entityType1, index2, entityType2, table, foreignKeyName, columnNames1, columnNames2);

        /// <summary>
        ///     The foreign keys {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{foreignKeyName}' but with different delete behavior ('{deleteBehavior1}' and '{deleteBehavior2}').
        /// </summary>
        public static string DuplicateForeignKeyDeleteBehaviorMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object foreignKeyName, [CanBeNull] object deleteBehavior1, [CanBeNull] object deleteBehavior2)
            => string.Format(
                GetString("DuplicateForeignKeyDeleteBehaviorMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(foreignKeyName), nameof(deleteBehavior1), nameof(deleteBehavior2)),
                index1, entityType1, index2, entityType2, table, foreignKeyName, deleteBehavior1, deleteBehavior2);

        /// <summary>
        ///     The foreign keys {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{foreignKeyName}' but referencing different principal columns ({principalColumnNames1} and {principalColumnNames2}).
        /// </summary>
        public static string DuplicateForeignKeyPrincipalColumnMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object foreignKeyName, [CanBeNull] object principalColumnNames1, [CanBeNull] object principalColumnNames2)
            => string.Format(
                GetString("DuplicateForeignKeyPrincipalColumnMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(foreignKeyName), nameof(principalColumnNames1), nameof(principalColumnNames2)),
                index1, entityType1, index2, entityType2, table, foreignKeyName, principalColumnNames1, principalColumnNames2);

        /// <summary>
        ///     The foreign keys {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{foreignKeyName}' but referencing different principal tables ('{principalTable1}' and '{principalTable2}').
        /// </summary>
        public static string DuplicateForeignKeyPrincipalTableMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object foreignKeyName, [CanBeNull] object principalTable1, [CanBeNull] object principalTable2)
            => string.Format(
                GetString("DuplicateForeignKeyPrincipalTableMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(foreignKeyName), nameof(principalTable1), nameof(principalTable2)),
                index1, entityType1, index2, entityType2, table, foreignKeyName, principalTable1, principalTable2);

        /// <summary>
        ///     The foreign keys {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{foreignKeyName}' but with different uniqueness.
        /// </summary>
        public static string DuplicateForeignKeyUniquenessMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object foreignKeyName)
            => string.Format(
                GetString("DuplicateForeignKeyUniquenessMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(foreignKeyName)),
                index1, entityType1, index2, entityType2, table, foreignKeyName);

        /// <summary>
        ///     The indexes {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{indexName}' but with different columns ({columnNames1} and {columnNames2}).
        /// </summary>
        public static string DuplicateIndexColumnMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object indexName, [CanBeNull] object columnNames1, [CanBeNull] object columnNames2)
            => string.Format(
                GetString("DuplicateIndexColumnMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(indexName), nameof(columnNames1), nameof(columnNames2)),
                index1, entityType1, index2, entityType2, table, indexName, columnNames1, columnNames2);

        /// <summary>
        ///     The indexes {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{indexName}' but with different uniqueness.
        /// </summary>
        public static string DuplicateIndexUniquenessMismatch([CanBeNull] object index1, [CanBeNull] object entityType1, [CanBeNull] object index2, [CanBeNull] object entityType2, [CanBeNull] object table, [CanBeNull] object indexName)
            => string.Format(
                GetString("DuplicateIndexUniquenessMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(indexName)),
                index1, entityType1, index2, entityType2, table, indexName);

        /// <summary>
        ///     No mapping to a relational type can be found for property '{entity}.{property}' with the CLR type '{clrType}'.
        /// </summary>
        public static string UnsupportedPropertyType([CanBeNull] object entity, [CanBeNull] object property, [CanBeNull] object clrType)
            => string.Format(
                GetString("UnsupportedPropertyType", nameof(entity), nameof(property), nameof(clrType)),
                entity, property, clrType);

        /// <summary>
        /// This function can only be invoked from LINQ to Entities.
        /// </summary>
        public static string DbFunctionsDirectCall
        {
            get { return GetString("DbFunctionsDirectCall"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}
